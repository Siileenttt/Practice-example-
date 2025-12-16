format pe console

entry Start

include "D:\\assembly language\\Fasm_Assembler\\fasmw17334\\INCLUDE\\win32a.inc"

section ".data" code readable  executable

Start:
    call    read_hex
    mov     edx,eax
    call    read_hex
    add     eax,edx
    add     eax,eax
    call    print_eax

    ; call exit process

    push    0;
    call    [ExitProcess]



include "D:\\assembly language\\Fasm_Assembler\\fasmw17334\\INCLUDE\\training.inc"