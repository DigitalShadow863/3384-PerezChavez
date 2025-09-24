nota = float(input("Ingrese la nota: "))
if nota >= 12.5:
    if nota >= 18:
        print("El estudiante aprobó con distinción")
    else:
        print("El estudiante aprobó")
else:
    print("El estudiante desaprobó")
