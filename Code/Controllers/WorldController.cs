using Godot;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Sanca.Controllers;

public partial class WorldController : Node2D {
    private List<InteractableController> openInteractables = new();
    //Temporário
    public static WorldController cont;

    public override void _Ready(){
        cont = this;
    }
    public void AddMenu(InteractableController toAdd){
        openInteractables.Add(toAdd);
    }

    /*Oq isso faz analisar os inputs não tratados por ngm e
    se com ctz nao tem um menu lá, fechar tds os menus. 
    */
    public override void _UnhandledInput(InputEvent @event)
    {
        if (@event is InputEventMouseButton mouseEvent)
        {
            if (mouseEvent.Pressed && (int)mouseEvent.ButtonIndex == 1)
            {
                foreach(InteractableController ic in openInteractables){
                    if (!ic.menu.GetVisibleRect().HasPoint(ToLocal(mouseEvent.GlobalPosition))){
                        ic.DestroyMenu();
                    }
                }
            }
        }
    }
}