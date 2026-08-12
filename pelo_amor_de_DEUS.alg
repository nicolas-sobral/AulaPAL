algoritmo "semnome"
// Função :
// Autor :
// Data : 01/04/2026
// Seção de Declarações 
var
nota1al1,nota2al1,nota3al1,nota1al2,nota2al2,nota3al2,media1,media2:real
n1,n2:caracter
inicio
escreva("digite o nome do primeiro aluno ")
leia (n1)
escreval("digite a primeira nota de ",n1)
leia(nota1al1)
escreval("digite a segunda nota de ",n1)
leia(nota2al1)
escreval("digite a terceira nota de ",n1)
leia(nota3al1)
escreva("digite o nome do outro aluno ")
leia(n2)
escreval("agr digite  a 1ª nota de ", n2)
leia(nota1al2)
escreval("digite a segunda nota de ",n2)
leia(nota2al2)
escreval("agr a ultima nota de ",n2)
leia(nota3al2)
media1<-(nota1al1 + nota2al1 + nota3al1)/3
media2<-(nota1al2 + nota2al2+ nota3al2)/3
se (media1 > media2) entao
escreva("o aluno ",n1, " teve a maior média, sendo ", media1)
senao
escreva("o aluno ",n2, " teve a maior média, sendo ",media2)
fimse
fimalgoritmo
