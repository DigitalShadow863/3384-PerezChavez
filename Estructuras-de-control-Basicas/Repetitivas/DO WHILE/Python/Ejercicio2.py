secreto = 7

while True:
    intento = int(input("Adivina el número (1-10): "))
    
    if intento < secreto:
        print("Demasiado bajo.")
    elif intento > secreto:
        print("Demasiado alto.")
    else:
        print("¡Correcto! Adivinaste el número.")
        break
