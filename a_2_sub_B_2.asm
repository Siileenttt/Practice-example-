format pe console
entry Start

include "D:\\assembly language\\Fasm_Assembler\\fasmw17334\\INCLUDE\\win32a.inc"

section ".text" code readable executable

Start:
    call    read_hex
    imul    eax
    mov     esi,eax
    call    read_hex
    imul    eax
    sub     esi,eax
    call    print_eax
    ; exit process

    push    0
    call    [ExitProcess]

include "D:\\assembly language\\Fasm_Assembler\\fasmw17334\\INCLUDE\\training.inc"