using Godot;
using System;

public partial class Player : RigidBody2D
{
	float JumpForce = 500f;
	public override void _Ready()
	{
		
	}

	public override void _PhysicsProcess(double delta)
	{
		if (Input.IsActionJustPressed("ui_accept")){
			ApplyImpulse(Vector2.Up * JumpForce);
		}
	}
}
