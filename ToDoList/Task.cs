using System;

public class Task{

public int ID {get; set;}
public string Decsription {get; set;}
public bool IsComplete {get; set;}

public Task (int id, string description){
ID = id;
Description = description;
IsComplete = false;}
}