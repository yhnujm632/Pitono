print("Hello1 wrold")
print("Hello2 wrold")
print("Hello3 wrold")
print("Hello4 wrold")
print("Hello5 wrold")
print("Hello6 wrold")
print("Hello7 wrold")
print("Hello8 wrold")
print("Hello9 wrold")
print("Hello10 wrold")
print("Hello11 wrold")
def pmt(dsfs):
    print(dsfs[3])
def prtt(dhd):
    pmt(dhd)

prtt([1, 4])
print("Calculador de la Forma Pendiente-Intersección") 
print("(por Mateo)\n") 


xPuntoUno = float(input("Introduzca la coordenada X de su primer punto: "))
yPuntoUno = float(input("Introduzca la coordenada Y de su primer punto: "))
xPuntoDos = float(input("Introduzca la coordenada X de su segundo punto: "))
yPuntoDos = float(input("Introduzca la coordenada Y de su segundo punto: "))


pendiente = (yPuntoUno - yPuntoDos) / (xPuntoUno - xPuntoDos)


yintersección = (yPuntoUno - (pendiente * xPuntoUno))


print("\nSu forma pendiente-intersección es:")
print("y = " + cad(pendiente) + "x + " + cad(yintersección)) 

