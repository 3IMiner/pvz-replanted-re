# Reloaded.Gameplay.Coin FindGoldMagnetTarget()

- 类：`Plant`
- 汇编行数：253

## 反汇编

```asm

Disassembly:
	mov [rsp+20h],rsi
	push rdi
	push r12
	push r15
	sub rsp,0A0h
	cmp byte ptr [184EEB673h],0
	mov rdi,rcx
	movaps [rsp+70h],xmm8
	jne short 00000001806AF1BEh
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C7E1B0h]
	call 00000001804FEB70h
	lea rcx,[184C7E288h]
	call 00000001804FEB70h
	mov byte ptr [184EEB673h],1
	mov rax,[rdi+18h]
	xor r12d,r12d
	mov [rsp+0C0h],rbx
	mov r15d,r12d
	mov [rsp+0C8h],rbp
	xorps xmm8,xmm8
	mov [rsp+0D0h],r14
	mov esi,r12d
	movaps [rsp+90h],xmm6
	mov edx,r12d
	movaps [rsp+80h],xmm7
	movaps [rsp+60h],xmm9
	movaps [rsp+50h],xmm10
	movaps [rsp+40h],xmm11
	movaps [rsp+30h],xmm12
	test rax,rax
	je near ptr 00000001806AF3C4h
	movss xmm11,dword ptr [183C33C40h]
	movss xmm12,dword ptr [183C33DC4h]
	nop dword ptr [rax]
	mov rcx,[rax+88h]
	test rcx,rcx
	je near ptr 00000001806AF3C4h
	cmp edx,[rcx+28h]
	jge near ptr 00000001806AF366h
	mov rax,[rdi+18h]
	test rax,rax
	je near ptr 00000001806AF3C4h
	mov rcx,[rax+88h]
	test rcx,rcx
	je near ptr 00000001806AF3C4h
	mov r8,[184C7E288h]
	mov edx,esi
	call 0000000182449330h
	mov rbx,rax
	test rax,rax
	je near ptr 00000001806AF3C4h
	cmp [rax+8Ch],r12b
	jne near ptr 00000001806AF354h
	cmp dword ptr [rax+0B0h],1
	je short 00000001806AF2ACh
	cmp dword ptr [rax+0B0h],2
	je short 00000001806AF2ACh
	cmp dword ptr [rax+0B0h],3
	jne near ptr 00000001806AF354h
	cmp dword ptr [rax+0B4h],5
	je near ptr 00000001806AF354h
	cmp [rax+0A8h],r12b
	jne near ptr 00000001806AF354h
	cmp dword ptr [rax+0A4h],32h
	jl near ptr 00000001806AF354h
	mov rcx,[184C2AFC0h]
	movss xmm6,dword ptr [rdi+20h]
	movss xmm7,dword ptr [rdi+24h]
	movss xmm9,dword ptr [rax+70h]
	mov ebp,[rax+28h]
	movss xmm10,dword ptr [rax+74h]
	mov r14d,[rax+2Ch]
	cmp [rcx+0E4h],r12d
	jne short 00000001806AF305h
	call 00000001804FEEB0h
	xorps xmm3,xmm3
	mov [rsp+20h],r12
	xorps xmm2,xmm2
	addss xmm7,xmm12
	cvtsi2ss xmm3,r14d
	cvtsi2ss xmm2,ebp
	mulss xmm3,xmm11
	addss xmm6,xmm12
	mulss xmm2,xmm11
	movaps xmm1,xmm7
	addss xmm3,xmm10
	movaps xmm0,xmm6
	addss xmm2,xmm9
	call 00000001806CB840h
	test r15,r15
	je short 00000001806AF34Dh
	comiss xmm8,xmm0
	jbe short 00000001806AF354h
	mov r15,rbx
	movaps xmm8,xmm0
	mov rax,[rdi+18h]
	inc esi
	mov edx,esi
	test rax,rax
	je short 00000001806AF3C4h
	jmp near ptr 00000001806AF230h
	movaps xmm12,[rsp+30h]
	mov rax,r15
	movaps xmm11,[rsp+40h]
	movaps xmm10,[rsp+50h]
	movaps xmm9,[rsp+60h]
	movaps xmm7,[rsp+80h]
	movaps xmm6,[rsp+90h]
	mov r14,[rsp+0D0h]
	mov rbp,[rsp+0C8h]
	mov rbx,[rsp+0C0h]
	mov rsi,[rsp+0D8h]
	movaps xmm8,[rsp+70h]
	add rsp,0A0h
	pop r15
	pop r12
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x20, rsi
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -8
	005 Move stack:0x0, r12
	006 ShiftStack -8
	007 Move stack:0x0, r15
	008 ShiftStack -160
	009 Compare [0x184EEB673], 0
	010 Move rdi, rcx
	011 Move stack:0x70, xmm8
	012 JumpIfNotEqual {20}
	013 LoadAddress rcx, [0x184C2AFC0]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184C7E1B0]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C7E288]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 Move [0x184EEB673], 1
	020 Move rax, [rdi+24]
	021 Move r12, 0
	022 Move stack:0xC0, rbx
	023 Move r15, r12
	024 Move stack:0xC8, rbp
	025 Move xmm8, 0
	026 Move stack:0xD0, r14
	027 Move rsi, r12
	028 Move stack:0x90, xmm6
	029 Move rdx, r12
	030 Move stack:0x80, xmm7
	031 Move stack:0x60, xmm9
	032 Move stack:0x50, xmm10
	033 Move stack:0x40, xmm11
	034 Move stack:0x30, xmm12
	035 Compare rax, 0
	036 JumpIfEqual {127}
	037 Move xmm11, [0x183C33C40]
	038 Move xmm12, [0x183C33DC4]
	039 Nop 
	040 Move rcx, [rax+136]
	041 Compare rcx, 0
	042 JumpIfEqual {127}
	043 Compare rdx, [rcx+40]
	044 JumpIfGreaterOrEqual {107}
	045 Move rax, [rdi+24]
	046 Compare rax, 0
	047 JumpIfEqual {127}
	048 Move rcx, [rax+136]
	049 Compare rcx, 0
	050 JumpIfEqual {127}
	051 Move r8, [0x184C7E288]
	052 Move rdx, rsi
	053 Call 0x182449330, rcx, rdx
	054 Move rbx, rax
	055 Compare rax, 0
	056 JumpIfEqual {127}
	057 Compare [rax+140], r12
	058 JumpIfNotEqual {101}
	059 Compare [rax+176], 1
	060 JumpIfEqual {65}
	061 Compare [rax+176], 2
	062 JumpIfEqual {65}
	063 Compare [rax+176], 3
	064 JumpIfNotEqual {101}
	065 Compare [rax+180], 5
	066 JumpIfEqual {101}
	067 Compare [rax+168], r12
	068 JumpIfNotEqual {101}
	069 Compare [rax+164], 50
	070 JumpIfLess {101}
	071 Move rcx, typeof(Reloaded.Gameplay.Common)
	072 Move xmm6, [rdi+32]
	073 Move xmm7, [rdi+36]
	074 Move xmm9, [rax+112]
	075 Move rbp, [rax+40]
	076 Move xmm10, [rax+116]
	077 Move r14, [rax+44]
	078 Compare [rcx+228], r12
	079 JumpIfNotEqual {81}
	080 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	081 Move xmm3, 0
	082 Move stack:0x20, r12
	083 Move xmm2, 0
	084 Add xmm7, xmm7, xmm12
	085 NotImplemented "cvtsi2ss xmm3,r14d"
	086 NotImplemented "cvtsi2ss xmm2,ebp"
	087 Multiply xmm3, xmm3, xmm11
	088 Add xmm6, xmm6, xmm12
	089 Multiply xmm2, xmm2, xmm11
	090 Move xmm1, xmm7
	091 Add xmm3, xmm3, xmm10
	092 Move xmm0, xmm6
	093 Add xmm2, xmm2, xmm9
	094 Call Common.Distance2D, xmm0, xmm1, xmm2, xmm3, stack:0x0
	095 Compare r15, 0
	096 JumpIfEqual {99}
	097 Compare xmm8, xmm0
	098 JumpIfLessOrEqual {101}
	099 Move r15, rbx
	100 Move xmm8, xmm0
	101 Move rax, [rdi+24]
	102 Add rsi, rsi, 1
	103 Move rdx, rsi
	104 Compare rax, 0
	105 JumpIfEqual {127}
	106 Goto {40}
	107 Move xmm12, stack:0x30
	108 Move rax, r15
	109 Move xmm11, stack:0x40
	110 Move xmm10, stack:0x50
	111 Move xmm9, stack:0x60
	112 Move xmm7, stack:0x80
	113 Move xmm6, stack:0x90
	114 Move r14, stack:0xD0
	115 Move rbp, stack:0xC8
	116 Move rbx, stack:0xC0
	117 Move rsi, stack:0xD8
	118 Move xmm8, stack:0x70
	119 ShiftStack 160
	120 Move r15, stack:0x0
	121 ShiftStack 8
	122 Move r12, stack:0x0
	123 ShiftStack 8
	124 Move rdi, stack:0x0
	125 ShiftStack 8
	126 Return rax
	127 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
