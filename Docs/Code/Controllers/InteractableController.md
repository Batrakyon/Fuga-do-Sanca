# public partial class InteractableController
namespace: Sanca.Controllers  
using: Godot  
herança: Sprite2D  

## Propriedades
- public WorldController worldController;
- public string popupMenuPath;
- public List\<template\> callMethods;
- private bool isActive;
- private delegate void template();
## Métodos
### public void OpenMenu ()
Instância um PopupMenu a partir do popuMenuPath, muda isActive, registra ele no worldController e configura os signals dele a partir do callMethods.

### public override void _Input(InputEvent @event)
Chama o OpenMenu se não isActive. 