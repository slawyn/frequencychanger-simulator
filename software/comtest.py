
import struct
import serial
from serial import *
import sys
import glob
import time

import datetime
import threading
import time


axreading = False
ser = None
comsocket = None
axframe = b"\x41\x58\x05\00\00\00\00\00\00\00"	
running = False

def log(s):
	print(str(datetime.datetime.now().time())+"::log::%s"%(s))

def serial_ports():
	ports = ['COM%s' % (i + 1) for i in range(256)]
	i = 0
	result = []
	for port in ports:
		try:
			s = serial.Serial(port)
			result.append(port)
			s.close()
	
		except (Exception):
			pass
			i = i+1
	return result


def receiver():
	global comsocket
	global running
	while running:
		r = comsocket.read()
		if r!= '' and r!=None and r!=b"":
			log(r)
		time.sleep(0.2)

def set_squarewave(frequency):
	global comsocket
	log("Setting square wave")
	integer = int(frequency,10)
	bytes_ = struct.pack(">I", integer)
			
	comsocket.write([0x06,3]);
	comsocket.write(bytes_)

def set_pwm(frequency):
	global comsocket
	
	log("Setting pwm")
	integer = int(frequency,10)
	bytes_ = struct.pack(">I", integer)
			
	comsocket.write([0x06,1]);
	comsocket.write(bytes_)

def init_com(port):
	global comsocket
	comsocket = serial.Serial()
	comsocket.port = port
	comsocket.baudrate = 115200
	comsocket.bytesize = serial.EIGHTBITS
	comsocket.parity = serial.PARITY_NONE
	comsocket.stopbits = serial.STOPBITS_ONE
	comsocket.xonxoff = False # Disable Software Flow Control
	comsocket.rtscts = False # Disable (RTS/CTS) flow Control
	comsocket.dsrdtr = False # Disable (DSR/DTR) flow Control
	comsocket.write_timeout = 0
	comsocket.timeout = 0	

	comsocket.open()
	comsocket.reset_output_buffer()
	comsocket.reset_input_buffer()
	
if __name__=="__main__":
	ports = serial_ports()

	print("\tStatus:Select a port.....0 - 255")
	for i in range(len(ports)):
		print("\t\t("+str(i)+")\t"+ports[i])
			

	# check if the input is correct
	nm = 0

	try: 
		nm = int(input())
		a = ports[nm]
	except:
		log("Exception:couldn't find any ports")
		sys.exit(1)
		
	try: 
		init_com(ports[nm])
	except:
		log("Exception:couldn't open port")
		sys.exit(1)

		
		# open the serial port
	if comsocket.isOpen():
		log("Status:"+comsocket.name + ' is open...')


	running = True
	thread_ = threading.Thread(target=receiver, args=( ))
	thread_.start()	

	try:
		while running:
			cmd= input("")
				
			if cmd == 'exit':
				running = False
				sys.exit(0)
				
			elif 'reset' in cmd:
				comsocket.write(b'/')
				
			elif 'set' in cmd:
				parsable = cmd.strip().split(' ')
				log(parsable)
				try:
					if parsable[1] == "pwm":
						set_pwm(parsable[2])				
					elif parsable[1] == "square":
						set_squarewave(parsable[2])
				except Exception as e: 
					log("Exception::"+str(e))
					
			
			elif cmd =='stopax':
				axreading = False
			else:
				log("#Unknown command!#")
				
	except:
		sys.exit(1)