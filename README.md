# Explorando Marte

Passos para a criação e finalização do projeto:

- [x] Criação da Estrura do Projeto DDD
- [x] Definir Requisição de Entrada e estrutura dos objetos
- [x] Montagem da Lógica do Exercício
- [x] Definir Retorno de Saída
- [x] Subir imagem dentro do dockerHub
- [ ] Salvar em Banco dados
- [ ] Interface de Entrada(FrontEnd)
- [ ] Interface de Saída(FrontEnd)
- [ ] Testes Automatizados 

Passos da execução do Projeto

1. Download do DockerHub  docker push wiliancalora/marteservices:latest
2. Rodar o projeto
3. Executar o endPoint Explorar com o Json abaixo

```
{
  "limite": {
    "x": 5,
    "y": 5
  },
  "sonda": [
    {
      "coordenada": {
        "x": 1,
        "y": 2
      },
      "direcao": "N",
      "instrucoes": "LMLMLMLMM"
    },
    {
      "coordenada": {
        "x": 6,
        "y": 2
      },
      "direcao": "N",
      "instrucoes": "LMLMLMLMM"
    },
    {
      "coordenada": {
        "x": 3,
        "y": 3
      },
      "direcao": "E",
      "instrucoes": "MMRMMRMRRM"
    }
  ]
}
```

4. Resultado
```
[
  "Resultado: A sonda c1ab1ef1-a22e-49aa-9c4f-c07f26173dad está na posição 1 3 N",
  "Resultado: A sonda 2fff8020-7789-4783-a2b2-d9dd8eb265ed está fora da área do planalto",
  "Resultado: A sonda dc9c548d-8658-4acd-8580-69c3cd59b12a está na posição 5 1 E"
]
```
