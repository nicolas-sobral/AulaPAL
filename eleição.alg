algoritmo "semnome"
// Função :
// Autor :
// Data : 11/03/2026
// Seção de Declarações 
var
totaleleitores, nulo, validos, brancos:inteiro
percbranco, percnulo, percvalido:real
inicio
escreva("quantos votos validos tiveram??? ")
leia(validos)
escreva("agora os votos brancos ")
leia(brancos)
escreva("e por fim os votos nulos ")
leia(nulo)
totaleleitores<-validos+brancos+nulo
percbranco<-(brancos*100)/totaleleitores
percnulo<-(nulo*100)/totaleleitores
percvalido<-(validos*100)/totaleleitores
escreva("o percentual de votos validos é ",percvalido,"%, o de votos brancos é ",percbranco, "%, e o de votos nulos é ",percnulo,"%")
fimalgoritmo
