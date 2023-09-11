using Godot;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Sanca.Controllers;

public partial class NpcController : CharacterBody2D{

[Export]
public int Speed {get;set;}
public List<List<Vector2>> paths;
[Export]
public string pathsJson;
public List<Vector2> currentPath;
[Export]
public bool Cycle{get;set;}
private bool going = true;
private int step = 0;

public override void _Ready(){
    var options = new JsonSerializerOptions
            {
                IncludeFields = true,
            };
    currentPath = JsonSerializer.Deserialize<List<Vector2>>(pathsJson,options);
}
public override void _PhysicsProcess(double delta){
    Velocity = Position.DirectionTo(currentPath[step]) * Speed;
        if (Position.DistanceTo(currentPath[step]) > 5)
        {
            MoveAndSlide();
        } else {
            if (currentPath.Count<step+2){
                if (Cycle){
                    going = false;
                    step --;
                } else {
                    SetPhysicsProcess(false);
                }
            } else if (going){
                step++;
            } else {
                if (Cycle && step == 0){
                    going = true;
                    step++;
                }
                step--;
            }
        }
}
}