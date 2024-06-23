// Definindo os valores do circuito
let Vs = 12.0 // Fonte de tensão em Volts
let R1 = 4.0 // Resistor R1 em Ohms
let R2 = 6.0 // Resistor R2 em Ohms
let RL = 8.0 // Resistor de carga em Ohms

// Corrente de Norton (IN)
let IN = Vs / (R1 + R2)

// Resistência de Norton (RN)
let RN = (R1 * R2) / (R1 + R2)

// Corrente no resistor de carga (IL) utilizando o circuito equivalente de Norton
let IL = IN * (RN / (RN + RL))

// Tensão no resistor de carga (VL) utilizando a lei de Ohm
let VL = IL * RL

// Resultados
printfn "Corrente de Norton (IN): %f A" IN
printfn "Resistência de Norton (RN): %f Ω" RN
printfn "Corrente no resistor de carga (IL): %f A" IL
printfn "Tensão no resistor de carga (VL): %f V" VL