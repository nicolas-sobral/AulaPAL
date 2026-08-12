algoritmo "semnome"
// Função :
// Autor :
// Data : 25/03/2026
// Seção de Declarações 
var
h,m,alt,p:real
sex:caracter
inicio
escreva("digite o seu sexo(gênero): ")
leia(sex)
escreva("digite agora sua altura: ")
leia(alt)
se(sex="feminino") entao
m<-(62.1*alt)-44.7
escreva("o peso ideal para você seria ",m)
senao
se(sex="masculino")entao
h<-(72.7*alt)-58
escreva("o peso ideal para você seria ",h)
senao
fimse
fimse
fimalgoritmo
