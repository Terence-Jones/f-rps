// For more information see https://aka.ms/fsharp-console-apps
let mutable machineThrow = ""
printfn "Hello this is a rock paper scissors game created in f#\n"
printfn "please enter your throw\n"
let uinput = System.Console.ReadLine()
printfn "you have chosen: %s" uinput
let random = System.Random()
let randomNum = random.Next(1,4)
printfn "random number chosen %d" randomNum
if randomNum = 1 then
    machineThrow <- "rock"
else if randomNum = 2 then
     machineThrow <- "paper"
else if randomNum = 3 then
    machineThrow <- "scissors"

printfn"machine throw is %s" machineThrow
if machineThrow = "rock" && uinput = "scissors" then
    printfn"machine has won"
else if machineThrow = "paper" && uinput = "rock" then 
    printfn"machine has won"
else if machineThrow = "scissors" && uinput = "paper" then 
    printfn"machine has won"
else if machineThrow = "scissors" && uinput = "scissors" then 
    printfn"it's a draw"
else if machineThrow = "rock" && uinput = "rock" then 
    printfn"it's a draw"
else if machineThrow = "paper" && uinput = "paper" then 
    printfn"it's a draw"
else 
    printfn"player has won"


