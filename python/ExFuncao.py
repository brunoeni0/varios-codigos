def mensagem1():
    print("Hello Wold")
    print("Olá, Mundo!")


def mensagem2():
    return "Hello Wold", "Olá, Mundo!"


mensagem1()
print()

texto = mensagem2()
print(texto[0])
print(texto[1])
