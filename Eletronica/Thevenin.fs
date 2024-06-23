module Thevenin

// Definindo os valores do circuito
let Vs = 12.0 // Fonte de tensão em Volts
let R1 = 4.0 // Resistor R1 em Ohms
let R2 = 6.0 // Resistor R2 em Ohms
let RL = 8.0 // Resistor de carga em Ohms

// Tensão de Thevenin (Vth)
let Vth = Vs * (R2 / (R1 + R2))

// Resistência de Thevenin (Rth)
let Rth = (R1 * R2) / (R1 + R2)

// Tensão no resistor de carga (VL) utilizando o circuito equivalente de Thevenin
let VL = Vth * (RL / (Rth + RL))

// Resultados
printfn "Tensão de Thevenin (Vth): %f V" Vth
printfn "Resistência de Thevenin (Rth): %f Ω" Rth
printfn "Tensão no resistor de carga (VL): %f V" VL
