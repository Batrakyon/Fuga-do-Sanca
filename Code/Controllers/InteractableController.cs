using Godot;
using System;
using System.Collections.Generic;

namespace Sanca.Controllers;

public partial class InteractableController : Sprite2D{
    public WorldController worldController;
    [Export]
    public string popupMenuPath;
    [Export]
    public int offsetY;
    [Export]
    public int offsetX;
    private List<template> callMethods;
    private bool isActive;
    private delegate void template();
    public PopupMenu menu;

    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventMouseButton mouseEvent)
        {   
            //Se for um clique em mim...
            if (mouseEvent.Pressed && (int)mouseEvent.ButtonIndex == 1 && GetRect().HasPoint(ToLocal(mouseEvent.GlobalPosition)))
            {
                //Crie meu Menu, registre no WorldController e mude a posição
                menu = (PopupMenu)GD.Load<PackedScene>(popupMenuPath).Instantiate();
                AddChild(menu);
                WorldController.cont.AddMenu(this);
                //Segue a mesma lógica de posicionamento do Java, o Y cresce pra baixo, por isso menos offsetY
                menu.Position = new Vector2I((int)GlobalPosition.X + offsetX,(int)(GlobalPosition.Y - offsetY));
                isActive = true;
                GetViewport().SetInputAsHandled();
            }
        }
    }
    public void DestroyMenu(){
        isActive = false;
        menu.QueueFree();
    }
}