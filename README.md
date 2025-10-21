## Jogo Joquemp� extendido de 15 Tipos � .NET C# (CLI)

Este projeto � uma vers�o expandida e balanceada do cl�ssico Joquemp� (Pedra, Papel e Tesoura), 
agora com 15 tipos de jogadas.  
Desenvolvido em .NET 9 (C#), o jogo � executado no CLI (linha de comando) e 
permite que dois jogadores reais escolham suas jogadas digitando um n�mero de 0 a 14.

---

## Conceito

Cada jogada � representada por uma entidade rica, respons�vel por conter sua pr�pria l�gica de vit�ria.  
Isso significa que a regra de quem vence est� dentro da pr�pria classe, mantendo o c�digo limpo, 
coeso e aderente a princ�pios de DDD e SOLID.

O jogo usa uma Factory para criar a jogada correta a partir de um enum `TipoDaJogada`, 
e um switch-case simples apenas para identificar as escolhas dos jogadores via CLI.

---

## Tipos dispon�veis

| C�digo | Tipo     |
|:------:|:----------|
| 0 | Pedra |
| 1 | Fogo |
| 2 | Tesoura |
| 3 | Cobra |
| 4 | Humano |
| 5 | �rvore |
| 6 | Lobo |
| 7 | Esponja |
| 8 | Papel |
| 9 | Ar |
| 10 | �gua |
| 11 | Drag�o |
| 12 | Dem�nio |
| 13 | Trov�o |
| 14 | Arma |

---

## Regras oficiais do Joquemp� 15

Cada tipo vence os 7 pr�ximos tipos e perde para os 7 anteriores, de forma circular.  
Por exemplo, �Pedra� vence os tipos de **1 at� 7** (voltando ao in�cio se necess�rio).

### Tabela completa de vit�rias

| Tipo | Vence |
|------|-------|
| **Pedra (0)** | Fogo (1), Tesoura (2), Cobra (3), Humano (4), �rvore (5), Lobo (6), Esponja (7) |
| **Fogo (1)** | Tesoura (2), Cobra (3), Humano (4), �rvore (5), Lobo (6), Esponja (7), Papel (8) |
| **Tesoura (2)** | Cobra (3), Humano (4), �rvore (5), Lobo (6), Esponja (7), Papel (8), Ar (9) |
| **Cobra (3)** | Humano (4), �rvore (5), Lobo (6), Esponja (7), Papel (8), Ar (9), �gua (10) |
| **Humano (4)** | �rvore (5), Lobo (6), Esponja (7), Papel (8), Ar (9), �gua (10), Drag�o (11) |
| **�rvore (5)** | Lobo (6), Esponja (7), Papel (8), Ar (9), �gua (10), Drag�o (11), Dem�nio (12) |
| **Lobo (6)** | Esponja (7), Papel (8), Ar (9), �gua (10), Drag�o (11), Dem�nio (12), Trov�o (13) |
| **Esponja (7)** | Papel (8), Ar (9), �gua (10), Drag�o (11), Dem�nio (12), Trov�o (13), Arma (14) |
| **Papel (8)** | Ar (9), �gua (10), Drag�o (11), Dem�nio (12), Trov�o (13), Arma (14), Pedra (0) |
| **Ar (9)** | �gua (10), Drag�o (11), Dem�nio (12), Trov�o (13), Arma (14), Pedra (0), Fogo (1) |
| **�gua (10)** | Drag�o (11), Dem�nio (12), Trov�o (13), Arma (14), Pedra (0), Fogo (1), Tesoura (2) |
| **Drag�o (11)** | Dem�nio (12), Trov�o (13), Arma (14), Pedra (0), Fogo (1), Tesoura (2), Cobra (3) |
| **Dem�nio (12)** | Trov�o (13), Arma (14), Pedra (0), Fogo (1), Tesoura (2), Cobra (3), Humano (4) |
| **Trov�o (13)** | Arma (14), Pedra (0), Fogo (1), Tesoura (2), Cobra (3), Humano (4), �rvore (5) |
| **Arma (14)** | Pedra (0), Fogo (1), Tesoura (2), Cobra (3), Humano (4), �rvore (5), Lobo (6) |


## Inje��o de Depend�ncia

O projeto usa o container de DI nativo do .NET e pode registrar automaticamente as classes que implementam `ITipo`.

### Com Scrutor (recomendado)

dotnet add package Scrutor

### Execu��o via CLI

dotnet run

### Exemplo de uso

Digite a jogada do Jogador 1 (0-14): 0
Digite a jogada do Jogador 2 (0-14): 11

Jogador 1 escolheu: Pedra
Jogador 2 escolheu: Drag�o

Resultado: Jogador 2 venceu!

### Extensibilidade

Para adicionar um novo tipo:

Crie uma nova classe que implemente ITipo.

Defina em um array os tipos que ela vence.

Adicione o novo valor no enum Jogada.

Nenhuma altera��o no restante do c�digo ser� necess�ria.

### Padr�es aplicados

DDD (Domain-Driven Design)

Entidades Ricas

Factory Pattern

Inje��o de Depend�ncia

Responsabilidade �nica (SRP - SOLID)

### Autor

Projeto desenvolvido em .NET 9 / C#, com foco em:

Design orientado a dom�nio

Boas pr�ticas de arquitetura

Intera��o via linha de comando

Demonstra��o de DI, enums e factories



