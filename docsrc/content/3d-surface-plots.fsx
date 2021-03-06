(*** hide ***)
#r "netstandard"
#r @"../../lib/Formatting/FSharp.Plotly.dll"

(** 
# FSharp.Plotly: 3D surface plot Charts

*Summary:* This example shows how to create 3D surface plots in F#.
*)

open System
open FSharp.Plotly 


// Generate linearly spaced vector
let linspace (min,max,n) = 
    if n <= 2 then failwithf "n needs to be larger then 2"
    let bw = float (max - min) / (float n - 1.)
    Array.init n (fun i -> min + (bw * float i))
    //[|min ..bw ..max|]
  

// Create example data
let size = 100
let x = linspace(-2. * Math.PI, 2. * Math.PI, size)
let y = linspace(-2. * Math.PI, 2. * Math.PI, size)

let f x y = - (5. * x / (x**2. + y**2. + 1.) )

let z = 
    Array.init size (fun i -> 
        Array.init size (fun j -> f x.[j] y.[i] )
                    )

let rnd = System.Random()
let a = Array.init 50 (fun _ -> rnd.NextDouble())
let b = Array.init 50 (fun _ -> rnd.NextDouble())
let c = Array.init 50 (fun _ -> rnd.NextDouble())


let surface = 
    z
    |> Chart.Surface

(***do-not-eval***)
surface |> Chart.Show

(*** include-value:surface ***)

// Create simple example data were x y and z is given (z is a xy-Matrix)
let x' = [0.;2.5]
let y' = [0.;2.5]
let z' = [
    [1.;1.;]; // row wise (length x)
    [1.;2.;];
    ] // column (length y)

let surface2 = 
    Chart.Surface(z',x',y',Opacity=0.5,Contours=Contours.initXyz(Show=true))

(***do-not-eval***)
surface2 |> Chart.Show

(*** include-value:surface2 ***)


