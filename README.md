# My Ball - Roll a Ball Enhanced

Este projeto é uma versão aprimorada do clássico jogo "Roll a Ball" da Unity, com diversas melhorias que adicionam mais desafios e objetivos ao gameplay. No jogo, o jogador controla uma esfera usando as teclas W, A, S, D para movimentá-la pelo cenário. O objetivo principal é coletar todos os blocos amarelos espalhados pelo campo, evitando os obstáculos e o tempo limite.

![My Ball](./Assets/Cenário/My%20Ball.png)

## Funcionalidades do Jogo:
- **Coletar Blocos Amarelos:** O jogador precisa coletar todos os blocos amarelos dentro de um limite de 60 segundos. Se o jogador não conseguir pegar todos os blocos dentro desse tempo, ele será levado automaticamente para a tela de Game Over.

- **Sistema de Pontuação:** A cada bloco amarelo coletado, o jogador ganha um ponto. A pontuação é exibida na parte superior da tela e é atualizada em tempo real conforme o jogador avança no jogo.

- **Cronômetro:** O tempo total de jogo é limitado a 60 segundos. O cronômetro é exibido na tela e vai diminuindo continuamente. O jogador precisa coletar todos os blocos amarelos antes que o tempo acabe. Caso o cronômetro chegue a zero e o jogador ainda não tenha completado o objetivo, ele será levado à tela de Game Over.

- **Blocos Vermelhos:** Se o jogador tocar em um bloco vermelho, o jogo terminará instantaneamente, levando-o à tela de Game Over, onde será exibido o tempo total que durou a partida.

- **Limites do Cenário:** Além dos blocos vermelhos, se o jogador cair para fora dos limites do campo (sair do quadrado delimitado), ele também será levado à tela de Game Over, simulando uma queda no vazio.

- **Tela de Game Over:** Quando o jogador perde, seja por tocar em um bloco vermelho, cair fora do cenário ou deixar o tempo acabar, ele será levado à tela de Game Over. Nessa tela, o tempo total da partida é exibido, juntamente com as opções de Voltar ao Jogo ou Sair do Jogo.

- **Tela de Vitória (You Win):** Se o jogador conseguir coletar todos os blocos amarelos antes que o tempo acabe, ele será levado à tela de You Win, onde também será exibido o tempo total que durou a partida.

## Referenciais

- [Unity Roll a Ball Tutorial](https://learn.unity.com/project/roll-a-ball)
- [Vídeo 1 - Melhorias no Roll a Ball](https://www.youtube.com/watch?v=K4uOjb5p3Io)
- [Vídeo 2 - Tutorial de Blocos](https://www.youtube.com/watch?v=DX7HyN7oJjE)
- [Vídeo 3 - Implementando Game Over](https://www.youtube.com/watch?v=7xGhPUz8C2M)
- [Documentação Unity - Renderer](https://docs.unity3d.com/ScriptReference/Renderer-enabled.html)
- [Documentação Unity - Collider](https://docs.unity3d.com/460/Documentation/ScriptReference/Collider-enabled.htm)
- [Coroutines Unity](https://vionixstudio.com/2021/04/03/unity-coroutine-tutorial)
- [Vídeo 4 - Física no Unity](https://www.youtube.com/watch?v=POq1i8FyRyQ)

## Autoria

Ana Laiz Novais De Farias  
Engenharia da Computação Insper - 7º Semestre
