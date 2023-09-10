# public partial class PlayerController
namespace: Sanca.Controllers
using: Godot
herança: CarachterBody2D

## Propriedades
- public int Speed {get;set;}
- public List<List<Vector2>> paths
- public List<Vector2> currentPath
- public bool Cycle{get;set}
- private int step = 0;

## Métodos
### public override void _PhysicsProcess(double delta)
Se move em direção ao step do currentPath usando Position.DirectionTo.
Ao chegar lá, vai para o stop seguinte.
Se for o setop final, checa se o movimento é cíclico com o Cyle. Se for, retorna. Se não for, currentPath passa a nulo. 