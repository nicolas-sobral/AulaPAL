algoritmo "semnome"
// Função :
// Autor :
// Data : 18/03/2026
// Seção de Declarações 
var
faixa1,faixa2,totaleleitores:inteiro
percfaixa1,percfaixa2:real
inicio
escreva("quantos votos a faixa 1 teve? ")
leia(faixa1)
escreva("e quantos a faixa 2 teve? ")
leia (faixa2)
totaleleitores<-faixa1+faixa2
percfaixa1<-(faixa1*100)/totaleleitores
percfaixa2<-(faixa2*100)/totaleleitores
escreval("o total de eleitores é ",totaleleitores)
escreva(" e os percentuais de cada faixa é ",percfaixa1, " ",percfaixa2)
fimalgoritmo
