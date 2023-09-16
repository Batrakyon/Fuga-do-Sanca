# public partial class NpcController
namespace: Sanca.Controllers  
using: Godot  
herança: CarachterBody2D  

## Propriedades
- public int Speed {get;set;} (Export)
- public string pathJson  (Export);
- public List\<List\<Vector2\>\> paths
- public List\<Vector2\> currentPath
- public bool Cycle{get;set} (Export)
- private int step = 0;
- private bool going = true;

## Métodos
### public override void _Ready()
Deserializa o pathsJson para o currentPath, futuramente para o paths
### public override void _PhysicsProcess(double delta)
Se move em direção ao step do currentPath usando Position.DirectionTo.  
Ao chegar lá, vai para o step seguinte.  
Se for o step final, checa se o movimento é cíclico com o Cyle. Se for, retorna. Se não for, currentPath passa a nulo. 