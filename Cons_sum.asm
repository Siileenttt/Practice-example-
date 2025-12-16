format pe console

entry Start

include "D:\\assembly language\\Fasm_Assembler\\fasmw17334\\INCLUDE\\win32a.inc"

section ".text" code readable  executable

Start:

    call    read_hex
    mov     ecx,eax
	xor		edx,edx
Loop1:
    call    read_hex
    add     edx,eax
    dec     ecx
    cmp     ecx,0x0
    jnz     Loop1
	movzx		eax,dx
    call    print_eax


    push    0
    call    [ExitProcess]


include "D:\\assembly language\\Fasm_Assembler\\fasmw17334\\INCLUDE\\training.inc"