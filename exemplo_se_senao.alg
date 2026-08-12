algoritmo "semnome"
// Função :
// Autor :
// Data : 25/03/2026
// Seção de Declarações 
var
n1, n2, media:real
inicio
escreva("digite a primeira nota: ")
leia(n1)
escreva(" digite a segunda nota: ")
leia(n2)
media<-(n1+n2)/2
escreval("a media do aluno é ", media)
se (media>=7) entao
escreva("aluno aprovado")
senao
se((media>=5) e (media<=6.9)entao
escreva("aluno de recuperação")
senao
escreva("aluno reprovado")
fimse
fimse
fimalgoritmo
