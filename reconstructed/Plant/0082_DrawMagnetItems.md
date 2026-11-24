# System.Void DrawMagnetItems()

- 类：`Plant`
- 汇编行数：383

## 反汇编

```asm

Disassembly:
	push rbx
	push rsi
	push rdi
	push r13
	sub rsp,98h
	cmp byte ptr [184EEB65Ah],0
	mov rdi,rcx
	movaps [rsp+70h],xmm7
	movaps [rsp+60h],xmm8
	movaps [rsp+50h],xmm9
	movaps [rsp+40h],xmm10
	jne short 00000001806AE543h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	mov byte ptr [184EEB65Ah],1
	mov eax,[rdi+34h]
	xor r13d,r13d
	mov r9d,[rdi+70h]
	mov r8,rdi
	mov rdx,[rdi+18h]
	mov rcx,[rdi+10h]
	mov [rsp+30h],r13
	mov [rsp+28h],eax
	mov eax,[rdi+74h]
	mov [rsp+20h],eax
	call 00000001806B33C0h
	movss xmm7,dword ptr [183C33C4Ch]
	movaps xmm10,xmm0
	movss xmm8,dword ptr [183C33EBCh]
	mov ebx,r13d
	mov [rsp+0C0h],rbp
	mov esi,20h
	mov [rsp+0C8h],r12
	xorps xmm9,xmm9
	mov [rsp+0D0h],r14
	mov [rsp+90h],r15
	movaps [rsp+80h],xmm6
	nop word ptr [rax+rax]
	mov rax,[rdi+118h]
	test rax,rax
	je near ptr 00000001806AE821h
	cmp ebx,[rax+18h]
	jae near ptr 00000001806AE837h
	mov r15,[rsi+rax]
	test r15,r15
	je near ptr 00000001806AE821h
	cmp [r15+20h],r13d
	je near ptr 00000001806AE7C6h
	mov rax,[rdi+150h]
	test rax,rax
	je near ptr 00000001806AE821h
	cmp ebx,[rax+18h]
	jae near ptr 00000001806AE837h
	mov rcx,[184C2D478h]
	mov rbp,[rsi+rax]
	cmp [rcx+0E4h],r13d
	jne short 00000001806AE622h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rbp
	call 0000000183832770h
	test al,al
	jne short 00000001806AE666h
	mov rax,[rdi+150h]
	test rax,rax
	je near ptr 00000001806AE821h
	cmp ebx,[rax+18h]
	jae near ptr 00000001806AE837h
	mov rcx,[rsi+rax]
	test rcx,rcx
	je near ptr 00000001806AE821h
	mov eax,[r15+20h]
	cmp [rcx+40h],eax
	je near ptr 00000001806AE6F0h
	mov rcx,[rdi+140h]
	mov r14,[rdi+150h]
	mov rbp,[rdi+10h]
	mov r12d,[r15+20h]
	test rcx,rcx
	je near ptr 00000001806AE821h
	xor edx,edx
	call 0000000183815A20h
	test rbp,rbp
	je near ptr 00000001806AE821h
	xor r9d,r9d
	mov r8,rax
	mov edx,r12d
	mov rcx,rbp
	call 00000001807DB970h
	mov rbp,rax
	test r14,r14
	je near ptr 00000001806AE821h
	test rax,rax
	je short 00000001806AE6CFh
	mov rdx,[r14]
	mov rcx,rax
	mov rdx,[rdx+40h]
	call 00000001804FDEC0h
	test rax,rax
	je near ptr 00000001806AE827h
	cmp ebx,[r14+18h]
	jae near ptr 00000001806AE837h
	movsxd rax,ebx
	mov rdx,rbp
	add rax,4
	mov [rsi+r14],rbp
	lea rcx,[r14+rax*8]
	call 00000001804FDEA0h
	mov eax,[r15+20h]
	movaps xmm6,xmm7
	cmp eax,12h
	je short 00000001806AE708h
	add eax,0FFFFFFEDh
	cmp eax,1
	jbe short 00000001806AE708h
	movaps xmm6,xmm8
	mov rax,[rdi+150h]
	test rax,rax
	je near ptr 00000001806AE821h
	cmp ebx,[rax+18h]
	jae near ptr 00000001806AE837h
	mov rcx,[rsi+rax]
	test rcx,rcx
	je near ptr 00000001806AE821h
	mov edx,[rdi+38h]
	xor r8d,r8d
	call 00000001807B4790h
	mov rax,[rdi+150h]
	test rax,rax
	je near ptr 00000001806AE821h
	cmp ebx,[rax+18h]
	jae near ptr 00000001806AE837h
	mov rcx,[rsi+rax]
	test rcx,rcx
	je near ptr 00000001806AE821h
	movaps xmm3,xmm7
	mov [rsp+20h],r13
	movaps xmm2,xmm6
	movaps xmm1,xmm6
	call 00000001807B4730h
	mov rax,[rdi+150h]
	test rax,rax
	je near ptr 00000001806AE821h
	cmp ebx,[rax+18h]
	jae near ptr 00000001806AE837h
	mov rcx,[rsi+rax]
	test rcx,rcx
	je near ptr 00000001806AE821h
	movss xmm2,dword ptr [r15+14h]
	movaps xmm3,xmm9
	movss xmm1,dword ptr [r15+10h]
	subss xmm2,dword ptr [rdi+24h]
	subss xmm1,dword ptr [rdi+20h]
	mov [rsp+20h],r13
	addss xmm2,xmm10
	addss xmm1,xmm9
	call 00000001807B46A0h
	inc ebx
	add rsi,8
	cmp ebx,5
	jl near ptr 00000001806AE5C0h
	movaps xmm6,[rsp+80h]
	mov r15,[rsp+90h]
	mov r14,[rsp+0D0h]
	mov r12,[rsp+0C8h]
	mov rbp,[rsp+0C0h]
	movaps xmm7,[rsp+70h]
	movaps xmm8,[rsp+60h]
	movaps xmm9,[rsp+50h]
	movaps xmm10,[rsp+40h]
	add rsp,98h
	pop r13
	pop rdi
	pop rsi
	pop rbx
	ret
	call 00000001804FEE20h
	int 3
	call 00000001804FE790h
	mov rcx,rax
	xor edx,edx
	call 00000001804FEDE0h
	int 3
	call 00000001804FEE10h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -8
	004 Move stack:0x0, rsi
	005 ShiftStack -8
	006 Move stack:0x0, rdi
	007 ShiftStack -8
	008 Move stack:0x0, r13
	009 ShiftStack -152
	010 Compare [0x184EEB65A], 0
	011 Move rdi, rcx
	012 Move stack:0x70, xmm7
	013 Move stack:0x60, xmm8
	014 Move stack:0x50, xmm9
	015 Move stack:0x40, xmm10
	016 JumpIfNotEqual {20}
	017 LoadAddress rcx, [0x184C2D478]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 Move [0x184EEB65A], 1
	020 Move rax, [rdi+52]
	021 Move r13, 0
	022 Move r9, [rdi+112]
	023 Move r8, rdi
	024 Move rdx, [rdi+24]
	025 Move rcx, [rdi+16]
	026 Move stack:0x30, r13
	027 Move stack:0x28, rax
	028 Move rax, [rdi+116]
	029 Move stack:0x20, rax
	030 Call Plant.PlantDrawHeightOffset, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	031 Move xmm7, [0x183C33C4C]
	032 Move xmm10, xmm0
	033 Move xmm8, [0x183C33EBC]
	034 Move rbx, r13
	035 Move stack:0xC0, rbp
	036 Move rsi, 32
	037 Move stack:0xC8, r12
	038 Move xmm9, 0
	039 Move stack:0xD0, r14
	040 Move stack:0x90, r15
	041 Move stack:0x80, xmm6
	042 Nop 
	043 Move rax, [rdi+280]
	044 Compare rax, 0
	045 JumpIfEqual {186}
	046 Compare rbx, [rax+24]
	047 JumpIfGreaterOrEqual {193}
	048 Move r15, [rsi+rax]
	049 Compare r15, 0
	050 JumpIfEqual {186}
	051 Compare [r15+32], r13
	052 JumpIfEqual {163}
	053 Move rax, [rdi+336]
	054 Compare rax, 0
	055 JumpIfEqual {186}
	056 Compare rbx, [rax+24]
	057 JumpIfGreaterOrEqual {193}
	058 Move rcx, typeof(UnityEngine.Object)
	059 Move rbp, [rsi+rax]
	060 Compare [rcx+228], r13
	061 JumpIfNotEqual {63}
	062 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	063 Move r8, 0
	064 Move rdx, 0
	065 Move rcx, rbp
	066 Call Object.op_Equality, rcx, rdx, r8
	067 Compare rax, 0
	068 JumpIfNotEqual {80}
	069 Move rax, [rdi+336]
	070 Compare rax, 0
	071 JumpIfEqual {186}
	072 Compare rbx, [rax+24]
	073 JumpIfGreaterOrEqual {193}
	074 Move rcx, [rsi+rax]
	075 Compare rcx, 0
	076 JumpIfEqual {186}
	077 Move rax, [r15+32]
	078 Compare [rcx+64], rax
	079 JumpIfEqual {114}
	080 Move rcx, [rdi+320]
	081 Move r14, [rdi+336]
	082 Move rbp, [rdi+16]
	083 Move r12, [r15+32]
	084 Compare rcx, 0
	085 JumpIfEqual {186}
	086 Move rdx, 0
	087 Call Component.get_transform, rcx, rdx
	088 Compare rbp, 0
	089 JumpIfEqual {186}
	090 Move r9, 0
	091 Move r8, rax
	092 Move rdx, r12
	093 Move rcx, rbp
	094 Call GameplayActivity.CreateMagnetItemController, rcx, rdx, r8
	095 Move rbp, rax
	096 Compare r14, 0
	097 JumpIfEqual {186}
	098 Compare rax, 0
	099 JumpIfEqual {106}
	100 Move rdx, [r14]
	101 Move rcx, rax
	102 Move rdx, [rdx+64]
	103 Call 0x1804FDEC0, rcx, rdx, r8, r9
	104 Compare rax, 0
	105 JumpIfEqual {188}
	106 Compare rbx, [r14+24]
	107 JumpIfGreaterOrEqual {193}
	108 Move rax, rbx
	109 Move rdx, rbp
	110 Add rax, rax, 4
	111 Move [rsi+r14], rbp
	112 LoadAddress rcx, [r14+rax*8]
	113 Call 0x1804FDEA0, rcx, rdx, r8, r9
	114 Move rax, [r15+32]
	115 Move xmm6, xmm7
	116 Compare rax, 18
	117 JumpIfEqual {122}
	118 Add rax, rax, 18446744073709551597
	119 Compare rax, 1
	120 JumpIfLessOrEqual {122}
	121 Move xmm6, xmm8
	122 Move rax, [rdi+336]
	123 Compare rax, 0
	124 JumpIfEqual {186}
	125 Compare rbx, [rax+24]
	126 JumpIfGreaterOrEqual {193}
	127 Move rcx, [rsi+rax]
	128 Compare rcx, 0
	129 JumpIfEqual {186}
	130 Move rdx, [rdi+56]
	131 Move r8, 0
	132 Call MagnetItemController.SetRenderOrder, rcx, rdx
	133 Move rax, [rdi+336]
	134 Compare rax, 0
	135 JumpIfEqual {186}
	136 Compare rbx, [rax+24]
	137 JumpIfGreaterOrEqual {193}
	138 Move rcx, [rsi+rax]
	139 Compare rcx, 0
	140 JumpIfEqual {186}
	141 Move xmm3, xmm7
	142 Move stack:0x20, r13
	143 Move xmm2, xmm6
	144 Move xmm1, xmm6
	145 Call MagnetItemController.SetLocalScale, rcx, xmm1, xmm2, r9
	146 Move rax, [rdi+336]
	147 Compare rax, 0
	148 JumpIfEqual {186}
	149 Compare rbx, [rax+24]
	150 JumpIfGreaterOrEqual {193}
	151 Move rcx, [rsi+rax]
	152 Compare rcx, 0
	153 JumpIfEqual {186}
	154 Move xmm2, [r15+20]
	155 Move xmm3, xmm9
	156 Move xmm1, [r15+16]
	157 Subtract xmm2, xmm2, [rdi+36]
	158 Subtract xmm1, xmm1, [rdi+32]
	159 Move stack:0x20, r13
	160 Add xmm2, xmm2, xmm10
	161 Add xmm1, xmm1, xmm9
	162 Call MagnetItemController.SetLocalPosition, rcx, xmm1, xmm2, r9
	163 Add rbx, rbx, 1
	164 Add rsi, rsi, 8
	165 Compare rbx, 5
	166 JumpIfLess {43}
	167 Move xmm6, stack:0x80
	168 Move r15, stack:0x90
	169 Move r14, stack:0xD0
	170 Move r12, stack:0xC8
	171 Move rbp, stack:0xC0
	172 Move xmm7, stack:0x70
	173 Move xmm8, stack:0x60
	174 Move xmm9, stack:0x50
	175 Move xmm10, stack:0x40
	176 ShiftStack 152
	177 Move r13, stack:0x0
	178 ShiftStack 8
	179 Move rdi, stack:0x0
	180 ShiftStack 8
	181 Move rsi, stack:0x0
	182 ShiftStack 8
	183 Move rbx, stack:0x0
	184 ShiftStack 8
	185 Return 
	186 Call 0x1804FEE20, rcx, rdx, r8, r9
	187 Interrupt 
	188 Call 0x1804FE790, rcx, rdx, r8, r9
	189 Move rcx, rax
	190 Move rdx, 0
	191 Call 0x1804FEDE0, rcx, rdx, r8, r9
	192 Interrupt 
	193 Call 0x1804FEE10, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
