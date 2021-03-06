(*** hide ***)
#r "netstandard"
#r @"../../lib/Formatting/FSharp.Plotly.dll"


(** 
# FSharp.Plotly: Scatterplot matrix (Splom) Plot

*Summary:* This example shows how to plot a scatterplot matrix (splom) in F#.

Using a scatterplot matrix of several different variables can help to determine whether there are any
relationships among the variables in the dataset.
*)

open FSharp.Plotly 

let data = 
    ['A',[|1.;4.;3.4;0.7;|]; 'B',[|3.;1.5;1.7;2.3;|]; 'C',[|2.;4.;3.1;5.|]; 'D',[|4.;2.;2.;4.;|];]


let splom1 =
    Chart.Splom(data,Color="blue")

(***do-not-eval***)
splom1 |> Chart.Show

(*** include-value:splom1 ***)





