#!/usr/bin/env python

## Generate sine table
import matplotlib.pylab as plt
import matplotlib.ticker as ticker
import random

import math
import numpy as np


def to_hex(x, pos):
    return '%x' % int(x)

	# edited
def generate_sine_table(samples, scale, offset):
	xvals = []
	yvals = []
	step = 2.0 / samples
	step_sum = 0
	
	amp = (scale)/2-offset 				# maximale Amplitude  
	
	
	for idx in range(samples):


		value = amp*np.sin(step_sum*np.pi)+ amp+offset #offset fuer symmetrische Darstellung entspricht 50 %
		
		xvals.append(idx)
		
		descrete_value =  int(math.floor(value))
		yvals.append(descrete_value)
		step_sum = step_sum + step
		
		#print("%-3d) -> %s"%(idx, descrete_value))
		
	return (xvals,yvals)


def generate_triangle_table(samples, scale, offset):
	xvals = []
	yvals = []
	step = 2.0 / samples
	step_sum = 0
	
	amp = (scale)/2-offset 				# maximale Amplitude  
	
	dydx = scale/(samples/2)
	
	for idx in range(samples):
		
		if idx<samples/2:
			value = dydx*idx+offset #offset fuer symmetrische Darstellung entspricht 50 %
		else:	
			value = dydx*(samples-idx)+offset
		
		xvals.append(idx)
		
		descrete_value =  int(math.floor(value))
		yvals.append(descrete_value)
		step_sum = step_sum + step
		
		#print("%-3d) -> %s"%(idx, descrete_value))
		
	return (xvals,yvals)
	
def generate_exponential_table(samples, scale, offset):
	xvals = []
	yvals = []
	step = 2.0 / samples
	step_sum = 0
	
	amp = (scale)/2-offset 				# maximale Amplitude  
	
	dx = 1.00218747322
	for idx in range(samples):
		
		if idx<samples/2:
			value = scale*(1-math.pow(100,-idx/(samples/2))) 
		else:	
			value = scale*(math.pow(100,-(idx-(samples/2))/(samples/2)))
		
		xvals.append(idx)
		
		descrete_value =  int(math.floor(value))
		yvals.append(descrete_value)
		step_sum = step_sum + step
		
		#print("%-3d) -> %s"%(idx, descrete_value))
		
	return (xvals,yvals)
	
def generate_swatooth_table(samples, scale, offset):
	xvals = []
	yvals = []
	step = 2.0 / samples
	step_sum = 0

	dydx = (scale-offset)/(samples)
	for idx in range(samples):

		if idx<samples:
			value = dydx*idx+offset 

		xvals.append(idx)
		
		descrete_value =  int(math.floor(value))
		yvals.append(descrete_value)
		step_sum = step_sum + step
		
		#print("%-3d) -> %s"%(idx, descrete_value))
		
	return (xvals,yvals)

def generate_trapezoid_table(samples, scale, offset):
	xvals = []
	yvals = []
	step = 2.0 / samples
	step_sum = 0
	
	amp = (scale)/2-offset 				# maximale Amplitude  
	
	dydx = (scale-offset)/(samples/4)
	for idx in range(samples):

		if idx<samples/4:
			value = dydx*idx#offset fuer symmetrische Darstellung entspricht 50 %
		elif idx<samples/2:
			value = scale 
		elif idx<samples*3/4:
			value = dydx*(samples*3/4-idx)#offset fuer symmetrische Darstellung entspricht 50 %
		else:
			value = offset
			
		xvals.append(idx)
		
		descrete_value =  int(math.floor(value))
		yvals.append(descrete_value)
		step_sum = step_sum + step
		
		#print("%-3d) -> %s"%(idx, descrete_value))
		
	return (xvals,yvals)

def generate_square_table(samples, scale, offset):
	xvals = []
	yvals = []
	step = 2.0 / samples
	step_sum = 0
	
	amp = (scale)/2-offset 				# maximale Amplitude  
	
	dydx = 200/(samples/2)
	for idx in range(samples):

		if idx<samples/2:
			value = dydx*idx+offset + amp#offset fuer symmetrische Darstellung entspricht 50 %
		else:	
			value = dydx*(samples-idx) + offset
		
		xvals.append(idx)
		
		descrete_value =  int(math.floor(value))
		yvals.append(descrete_value)
		step_sum = step_sum + step
		
		#print("%-3d) -> %s"%(idx, descrete_value))
		
	return (xvals,yvals)



def save_tables(name, tables):
	size = len(tables)
	samples = len(tables[0][1])
	definesTypes = "#define dNumberOfSignalTypes %d\n"%(size)
	definesSize = "#define mTotalNumberOfValues %d\n"%(samples)
	tablestring =definesTypes+definesSize + "const uint32_t arr%s [dNumberOfSignalTypes][mTotalNumberOfValues] = {"%(name)
	

	for i in range(0,size):
		# Tabelle in string speichern
		idx =0
		t = 0
	
		string = "{"
		print(tables[i][1][idx])

		while True:
			string = string+hex(tables[i][1][idx])
			t = t + 1
			idx  = idx +1
			if idx == samples:
				break
			else:
				string=string+", "
				
			if(idx %10 == 0):
				string = string+"\n"
				
		string = string+"}"
		if(i+1<size):
			string = string + ",\n"
		tablestring = tablestring + string
				
	tablestring = tablestring + "};\n"
	
	#Pfad muss angepasst werden, hier wird die main.c eingelesen
	with open("umrichter/src/table.h","r") as content_file:
		old_file_data = content_file.readlines()
		content_file.close()
	
	delete = 0
	print(">>>>")
	
	
	# hier wird die Tabelle in main.c automatisch durch neue ersetzt.
	for line in old_file_data:
		if line == "//TABLE_START\n":
			new_file_data.append(line)
			delete = 1
		elif line == "//TABLE_END\n":
			new_file_data.append(line)
			delete = 0
		elif delete == 1:
			new_file_data.append(tablestring)
			delete = 2
		elif delete == 0:
			new_file_data.append(line)
		
	
	# neue Datei wird angelegt
	with open("umrichter/src/table.h","w") as new_file:
		for line in new_file_data:
			new_file.write(line)
	


if __name__ == '__main__':
	old_file_data = []
	new_file_data = []
	OFFSET = 0x1#0x100
	SAMPLES = 8000
	SCALE = 6250 		# ganzer Bereich
	
	tables = []

	try:
		tables.append(generate_sine_table(SAMPLES, SCALE, OFFSET))
		#tables.append(generate_triangle_table(SAMPLES,SCALE,OFFSET))
		tables.append (generate_exponential_table(SAMPLES, SCALE, OFFSET))
		save_tables("ui32SignalTable", tables)
	except Exception as e:
		print(e)
	
	
	

	f,ax = plt.subplots(1)
	ax.plot(tables[1][0], tables[1][1])
	
	axes = plt.gca()
	
	fmt = ticker.FuncFormatter(to_hex)
	axes.get_yaxis().set_major_locator(ticker.MultipleLocator(50))
	axes.get_yaxis().set_major_formatter(fmt)
	plt.show()
	
	