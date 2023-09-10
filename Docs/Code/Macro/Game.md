# public final class Game
namespace: Sacna.Macro  

## Propriedades
- private static readonly Game currentGame = new Game ();
- public Player player;
- public WorldController worldController;

## Métodos
### private Game ();

### public void InitGame()
Inicializa corretamente o currentGame

### public void StartNormalCutscene()
Congela o input e inicia uma sequencia scriptada dentro da engine padrão do jogo;

### public void StartVnCutscene()
Prepara o terreno e transiciona para uma scene do dialogic
