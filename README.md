## Jogo Joquempô extendido de 15 Tipos — .NET C# (CLI)

Este projeto é uma versão expandida e balanceada do clássico Joquempô (Pedra, Papel e Tesoura), 
agora com 15 tipos de jogadas.  
Desenvolvido em .NET 9 (C#), o jogo é executado no CLI (linha de comando) e 
permite que dois jogadores reais escolham suas jogadas digitando um número de 0 a 14.

---

## Conceito

Cada jogada é representada por uma entidade rica, responsável por conter sua própria lógica de vitória.  
Isso significa que a regra de quem vence está dentro da própria classe, mantendo o código limpo, 
coeso e aderente a princípios de DDD e SOLID.

O jogo usa uma Factory para criar a jogada correta a partir de um enum `TipoDaJogada`, 
e identificando as escolhas dos jogadores via CLI, ocultando as respostas dos jogadores só revelando no final da partida.

---

## Tipos disponíveis

| Código | Tipo     |
|:------:|:----------|
| 0 | Pedra |
| 1 | Fogo |
| 2 | Tesoura |
| 3 | Cobra |
| 4 | Humano |
| 5 | Árvore |
| 6 | Lobo |
| 7 | Esponja |
| 8 | Papel |
| 9 | Ar |
| 10 | Água |
| 11 | Dragão |
| 12 | Demônio |
| 13 | Trovão |
| 14 | Arma |

---

## Regras oficiais do Joquempô 15

Cada tipo vence os 7 próximos tipos e perde para os 7 anteriores, de forma circular.  
Por exemplo, “Pedra” vence os tipos de **1 até 7** (voltando ao início se necessário).

### Tabela completa de vitórias

| Tipo | Vence |
|------|-------|
| **Pedra (0)** | Fogo (1), Tesoura (2), Cobra (3), Humano (4), Árvore (5), Lobo (6), Esponja (7) |
| **Fogo (1)** | Tesoura (2), Cobra (3), Humano (4), Árvore (5), Lobo (6), Esponja (7), Papel (8) |
| **Tesoura (2)** | Cobra (3), Humano (4), Árvore (5), Lobo (6), Esponja (7), Papel (8), Ar (9) |
| **Cobra (3)** | Humano (4), Árvore (5), Lobo (6), Esponja (7), Papel (8), Ar (9), Água (10) |
| **Humano (4)** | Árvore (5), Lobo (6), Esponja (7), Papel (8), Ar (9), Água (10), Dragão (11) |
| **Árvore (5)** | Lobo (6), Esponja (7), Papel (8), Ar (9), Água (10), Dragão (11), Demônio (12) |
| **Lobo (6)** | Esponja (7), Papel (8), Ar (9), Água (10), Dragão (11), Demônio (12), Trovão (13) |
| **Esponja (7)** | Papel (8), Ar (9), Água (10), Dragão (11), Demônio (12), Trovão (13), Arma (14) |
| **Papel (8)** | Ar (9), Água (10), Dragão (11), Demônio (12), Trovão (13), Arma (14), Pedra (0) |
| **Ar (9)** | Água (10), Dragão (11), Demônio (12), Trovão (13), Arma (14), Pedra (0), Fogo (1) |
| **Água (10)** | Dragão (11), Demônio (12), Trovão (13), Arma (14), Pedra (0), Fogo (1), Tesoura (2) |
| **Dragão (11)** | Demônio (12), Trovão (13), Arma (14), Pedra (0), Fogo (1), Tesoura (2), Cobra (3) |
| **Demônio (12)** | Trovão (13), Arma (14), Pedra (0), Fogo (1), Tesoura (2), Cobra (3), Humano (4) |
| **Trovão (13)** | Arma (14), Pedra (0), Fogo (1), Tesoura (2), Cobra (3), Humano (4), Árvore (5) |
| **Arma (14)** | Pedra (0), Fogo (1), Tesoura (2), Cobra (3), Humano (4), Árvore (5), Lobo (6) |


## Injeção de Dependência

O projeto usa o container de DI nativo do .NET e pode registrar automaticamente as classes que implementam `ITipo`.

### Com Scrutor (recomendado)

dotnet add package Scrutor

### Execução via CLI

dotnet run

### Exemplo de uso

Digite a jogada do Jogador 1 (0-14): 0
Digite a jogada do Jogador 2 (0-14): 11

Jogador 1 escolheu: Pedra
Jogador 2 escolheu: Dragão

Resultado: Jogador 2 venceu!

### Extensibilidade

Para adicionar um novo tipo:

Crie uma nova classe que implemente ITipo.

Defina em um array os tipos que ela vence.

Adicione o novo valor no enum Jogada.

Nenhuma alteração no restante do código será necessária.

### Padrões aplicados

DDD (Domain-Driven Design)

Entidades Ricas

Factory Pattern

Injeção de Dependência

Responsabilidade Única (SRP - SOLID)

### Autor

Projeto desenvolvido em .NET 9 / C#, com foco em:

Design orientado a domínio

Boas práticas de arquitetura

Interação via linha de comando

Demonstração de DI, enums e factories



