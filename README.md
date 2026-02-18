# ⏱️ StopWatch em C#

Um projeto de **cronômetro em C#** feito para rodar no **terminal/console**, ideal para quem está aprendendo lógica de programação, entrada de dados, loops e controle de tempo.

---

## 🚀 Funcionalidades

- Contagem de tempo em:
  - **Segundos** (`s`) → Ex: `10s`
  - **Minutos** (`m`) → Ex: `1m`
- Tela de preparação antes de iniciar a contagem:
  - Ready → Set → Go
- Atualização do tempo a cada segundo
- Opção de sair do programa
- Reinicia automaticamente após o término da contagem

---

## 🧠 Como funciona

1. O usuário informa o tempo desejado no formato:
   - `10s` para 10 segundos
   - `1m` para 1 minuto
2. O programa identifica:
   - O valor numérico
   - O tipo de tempo (`s` ou `m`)
3. Caso seja minuto, o valor é convertido para segundos
4. O cronômetro inicia a contagem no console

---

## 🖥️ Exemplo de uso

```txt
S = Segundos => 10s = 10 Segundos
M = Minutos  => 1m  = 1 Minuto
0 = Sair

Quanto tempo deseja contar?
5s

Ready...
Set...
Go...

1
2
3
4
5
StopWatch finalizado

```
## 📦 Tecnologias utilizadas

C#

.NET (Console Application)

Thread.Sleep para controle de tempo

📚 Conceitos praticados

Métodos

Laços de repetição (while)

Manipulação de strings

Conversão de tipos (int.Parse, char.Parse)

Controle de fluxo

Estrutura de menu no console

▶️ Como executar

Clone o repositório:

```txt
git clone https://github.com/seu-usuario/StopWatch.git

```
## Entre na pasta do projeto:
```txt
cd StopWatch
```
## Execute o projeto:
```txt
dotnet run
