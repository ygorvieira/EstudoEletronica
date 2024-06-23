module FontesTensao

// Função para fonte de tensão ideal
let fonteTensaoIdeal (V: float) (R: float) : float =
    V

// Exemplo de uso
let V_ideal = fonteTensaoIdeal 12.0 8.0 // Tensão de 12V, carga de 8 ohms
printfn "Fonte de Tensão Ideal: %f V" V_ideal


// Função para fonte de tensão real
let fonteTensaoReal (V: float) (R_int: float) (R_load: float) : float =
    let I = V / (R_int + R_load)
    V - (I * R_int)

// Exemplo de uso
let V_real = fonteTensaoReal 12.0 1.0 8.0 // Tensão de 12V, resistência interna de 1 ohm, carga de 8 ohms
printfn "Fonte de Tensão Real: %f V" V_real


// Função para fonte de tensão quase ideal
let fonteTensaoQuaseIdeal (V: float) (R_int: float) (R_load: float) : float =
    let I = V / (R_int + R_load)
    V - (I * R_int)

// Exemplo de uso
let V_quaseIdeal = fonteTensaoQuaseIdeal 12.0 0.01 8.0 // Tensão de 12V, resistência interna de 0.01 ohms, carga de 8 ohms
printfn "Fonte de Tensão Quase Ideal: %f V" V_quaseIdeal


