print("Calculador de la Forma Pendiente-Intersección") 
print("(por Mateo)\n") 


xPuntoUno = float(input("Introduzca la coordenada X de su primer punto: "))
yPuntoUno = float(input("Introduzca la coordenada Y de su primer punto: "))
xPuntoDos = float(input("Introduzca la coordenada X de su segundo punto: "))
yPuntoDos = float(input("Introduzca la coordenada Y de su segundo punto: "))


pendiente = (yPuntoUno - yPuntoDos) / (xPuntoUno - xPuntoDos)


yintersección = (yPuntoUno - (pendiente * xPuntoUno))


print("\nSu forma pendiente-intersección es:")
print("y = " + str(pendiente) + "x + " + str(yintersección)) 
