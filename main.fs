module Lab2task3
let rec an n =
  if n = 0 then 1.0
  else (-1.) ** float n * ((float n + 1.) / ((float n * float n) + (2. ** float n)))

let n = 5
let result = an n

printfn "an(%d) = %f" n result
