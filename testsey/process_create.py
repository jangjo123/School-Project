#!C:\Users\YuSeungjun\anaconda3\python.exe
print("content-type: text/html; charset=utf-8\n")
#-*- coding: utf-8 -*-
import sys
import codecs
sys.stdout = codecs.getwriter("utf-8")(sys.stdout.detach())

 
import cgi
form = cgi.FieldStorage()
content = form["content"].value
print(content)