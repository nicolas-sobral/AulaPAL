algoritmo "semnome"
// Função :
// Autor :
// Data : 18/03/2026
// Seção de Declarações 
var
quantestoque,quanttotal,quantcompra:inteiro
produto:caracter
inicio
escreva("qual o produto? ")
leia (produto)
escreva("qual a quantidade maxima? ")
leia (quanttotal)
escreva("que quantidade ainda há no estoque? ")
leia (quantestoque)
quantcompra<-quanttotal-quantestoque
escreva ("o produto ", produto," precisa ser comprado ",quantcompra, " unidades")
fimalgoritmo
