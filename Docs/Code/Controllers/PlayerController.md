# public partial class PlayerController
namespace: Sanca.Controllers  
using: Godot  
herança: CarachterBody2D  

## Propriedades
- public int Speed {get;set;}

## Métodos
### public void GetMovement()
Absorve o input de movimento do teclado e adiciona na Velocity  

### public override void _PhysicsProcess(double delta)
Chama o GetMovement() e o MoveAndSlide()