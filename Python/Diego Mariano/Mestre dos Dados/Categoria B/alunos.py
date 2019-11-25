# coding: utf-8
import csv

alunos = open('nota.csv')
lista = csv.reader(alunos)

for item in lista:
    print (item)