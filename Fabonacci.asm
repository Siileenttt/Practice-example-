format pe console

entry Start

include "D:\\assembly language\\Fasm_Assembler\\fasmw17334\\INCLUDE\\win32a.inc"

section ".text" code readable  executable

Start:

    call    read_hex
    mov     ecx,eax
    xor     eax,eax
    xor     edx,edx
    inc     eax
Loop1:
    add     edx,eax
    mov     ebx,edx
    mov     edx,eax
    mov     eax,ebx
    dec     ecx
    cmp     ecx,0x0
    jnz     Loop1
    call    print_eax

    push    0
    call    [ExitProcess]


include "D:\\assembly language\\Fasm_Assembler\\fasmw17334\\INCLUDE\\training.inc"