codigo = 10
salario = 1500.00
nome = "josé"
situacao = True

tipo = type(salario)

print("código", codigo, "Nome:", nome, "o salario atual é de", salario)
print("código " + str(codigo) + " Nome: " + str(nome) + " o salario atual é de " + str(salario))
print("O tipo do salario é", tipo)
print()

codigo = 105
nome = 'José Santana'
salario = 1650.00
ativo = True

print("Código: %d" % codigo)
print("Nome: %s" % nome)
print("Salário: %.2f" % salario)
print("Ativo: %r" % ativo)
print()

codigo = int(input("Digite o código do funcionario: "))
nome = input("Digite o nome do funcionario: ")
salario = float(input("Informe o salário: "))
ativo = True

print()
print("Código: %d" % codigo)
print("Nome: %s" % nome)
print("Salario: %.2f" % salario)
print("Ativo: %r" % ativo)
