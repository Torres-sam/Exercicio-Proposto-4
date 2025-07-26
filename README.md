# 💼 Cálculo de Salário - Funcionário (C#)

Este projeto é um exercício simples em C# que calcula o salário de um funcionário com base em sua **ID**, quantidade de **horas trabalhadas** e o **valor pago por hora**.

Ideal para iniciantes que estão aprendendo a trabalhar com:
- Entrada de dados via console
- Conversão de tipos (`int` e `double`)
- Uso de `CultureInfo.InvariantCulture` para casas decimais
- Formatação de saída

---

## 📋 Funcionalidades

- Solicita o ID do funcionário
- Lê as horas trabalhadas
- Lê o valor da hora de trabalho
- Calcula e exibe o salário com 2 casas decimais

---

## 💻 Exemplo de uso

Id Funcionario: 25
Horas Trabalhadas: 100
Valor por Hora: 5.50

NUMBER = 25
SALARY = U$ 550.00

🚀 Como executar
Clone o repositório:
git clone https://github.com/Torres-sam/Exercicio-Proposto-4.git

Compile e execute com .NET CLI:

cd ExercicioSalarioFuncionario
dotnet run

💡 Certifique-se de ter o .NET SDK instalado (recomenda-se .NET 6 ou superior)

🧠 Conceitos usados
int.Parse() e double.Parse() para entrada de dados

CultureInfo.InvariantCulture para garantir ponto como separador decimal

ToString("F2") para formatação de valores com duas casas decimais


