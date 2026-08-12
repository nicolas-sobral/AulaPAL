algoritmo "semnome"
// Função :
// Autor :
// Data : 25/03/2026
// Seção de Declarações 
var
altp,largp,alta,larga,areap,areaa,azuprecisos:real
inicio
escreva("digite a altura da parede: ")
leia(altp)
escreva("agora digite a largura da parede: ")
leia(largp)
escreva("digite a altura do azulejo: ")
leia(alta)
escreva ("e a largura do azulejo: ")
leia(larga)
areap<-altp*largp
areaa<-alta*larga
azuprecisos<-areap/areaa
escreva("A quantidade de azulejos necessários é de ",azuprecisos)
fimalgoritmo
