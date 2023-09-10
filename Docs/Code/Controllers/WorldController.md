# public partial class InteractableController
namespace: Sanca.Controllers  
using: Godot  
herança: Node  

## Propriedades
- private List<PopupMenu> openMenus;
## Método
### public void AddMenu(PopupMenu toAdd)
adciona toAdd aos openMenus.

### public override void _Input(InputEvent @event)
Se houver menus ativos, e se a posição do clique não for em nenhum dos menus, fecha todos os menus ativos.  