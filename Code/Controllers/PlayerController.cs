using Godot;
using System;

namespace Sanca.Controllers;

public partial class PlayerController : CharacterBody2D{
    [Export]
    public int Speed {get;set;}


    public void GetMovement(){
        Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
        //Vector2 inputDirection = new(10f,2f);
        Velocity = inputDirection * Speed;
        Console.WriteLine("Movement chamado");
    }

    public override void _PhysicsProcess(double delta){
        GetMovement();
        MoveAndSlide();
    }
    
}