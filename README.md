# Desafios C#

Bem-vindo ao **Desafios C#**, um projeto desenvolvido em **C# com .NET**, com o objetivo de resolver três exercícios de lógica de programação propostos em um curso de Git e GitHub, na trilha de Back-End.

## 📌 Apresentação

Este projeto foi criado para praticar e consolidar conceitos fundamentais de programação, como estruturas de repetição, tratamento de entrada/saída, validação de dados, fórmulas matemáticas e estruturação de menus no console.

O código está escrito de forma simples, limpa e legível, servindo como ponto de partida para quem está desenvolvendo suas habilidades em programação Back-End.

## 🎯 Objetivos

- Resolver três desafios de lógica propostos no curso.
- Aplicar boas práticas de organização e nomenclatura em C#.
- Utilizar estruturas de repetição, condicionais e tratamento de erros/validações.
- Manter o código comentado apenas onde ajuda na compreensão da lógica.

## 🧩 Desafios implementados

### 1. Soma de 1 a 10

- Utiliza obrigatoriamente uma estrutura de repetição `for`.
- Calcula a soma dos números inteiros de 1 até 10.
- Exibe o resultado no console.

### 2. Calculadora de IMC

- Solicita ao usuário o peso (em quilogramas) e a altura (em metros).
- Calcula o IMC com a fórmula: `IMC = peso / (altura * altura)`.
- Exibe o valor calculado com duas casas decimais.
- Informa a classificação correspondente (abaixo do peso, peso normal, sobrepeso ou obesidade).
- Valida as entradas, impedindo peso ou altura iguais ou menores que zero.
- Trata entradas inválidas de forma amigável.

### 3. Calculadora simples

- Solicita dois números ao usuário.
- Permite escolher entre soma, subtração, multiplicação e divisão.
- Executa a operação escolhida e exibe o resultado no console.
- Impede divisão por zero.
- Trata opções e valores inválidos.

## 🛠️ Tecnologias utilizadas

- Linguagem: **C#**
- Framework: **.NET**
- IDE: Visual Studio / Visual Studio Code / Rider (qualquer editor com suporte a C#)

## ✅ Pré-requisitos

- [.NET SDK 10](https://dotnet.microsoft.com/download) instalado em sua máquina.
- (Opcional) Visual Studio 2022 ou superior, ou um editor de código como Visual Studio Code.

## 🚀 Instruções de execução

1. Clone o repositório:

   ```bash
   git clone https://github.com/<seu-usuario>/Desafios-CSharp.git
   cd Desafios-CSharp
   ```

2. Execute o projeto:

   ```bash
   dotnet run
   ```

   ou, no Visual Studio, abra a solução `Desafios-CSharp.slnx` e pressione **F5**.

## 💻 Exemplos de uso

Ao executar o projeto, um menu é exibido:

```
=================================
         DESAFIOS C#
=================================
1 - Soma de 1 a 10
2 - Calculadora de IMC
3 - Calculadora Simples
0 - Sair
=================================
Digite a opção desejada:
```

- **Opção 1:** exibe `A soma de 1 a 10 é: 55`.
- **Opção 2:** solicita peso e altura; ex.: peso `70` kg e altura `1.75` m → IMC `22.86` → **Peso normal**.
- **Opção 3:** solicita dois números e a operação; ex.: `10` e `2`, operação `4` (divisão) → `Resultado: 5`.

## 📁 Estrutura de pastas

```
Desafios-CSharp/
├── Desafios-CSharp.csproj
├── Desafios-CSharp.slnx
├── Program.cs
├── Desafios/
│   ├── CalculadoraImc.cs
│   ├── CalculadoraSimples.cs
│   └── DesafioSoma.cs
├── README.md
└── .gitignore
```

## 🙌 Conclusão

O projeto **Desafios C#** está completo e pronto para uso!

