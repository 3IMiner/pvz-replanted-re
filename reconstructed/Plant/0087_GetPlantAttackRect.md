# UnityEngine.Rect GetPlantAttackRect(Reloaded.Gameplay.PlantWeapon thePlantWeapon)

- 类：`Plant`
- 汇编行数：464

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rsi
	push rdi
	sub rsp,20h
	xorps xmm0,xmm0
	mov rdi,rcx
	movups [rcx],xmm0
	mov rcx,[rdx+10h]
	mov esi,r8d
	mov rbx,rdx
	test rcx,rcx
	je near ptr 00000001806B19EBh
	xor edx,edx
	call 00000001807DFA20h
	test al,al
	jne near ptr 00000001806B19A3h
	cmp esi,1
	jne short 00000001806B16E3h
	cmp dword ptr [rbx+70h],1Ch
	jne short 00000001806B16E3h
	movss xmm0,dword ptr [rbx+20h]
	addss xmm0,dword ptr [183C33EE0h]
	mov eax,[rbx+24h]
	mov [rdi+4],eax
	mov rax,rdi
	mov dword ptr [rdi],0
	movss dword ptr [rdi+8],xmm0
	movd xmm0,dword ptr [rbx+2Ch]
	cvtdq2ps xmm0,xmm0
	movss dword ptr [rdi+0Ch],xmm0
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	cmp dword ptr [rbx+70h],34h
	je near ptr 00000001806B1971h
	cmp dword ptr [rbx+70h],11h
	je near ptr 00000001806B1952h
	cmp dword ptr [rbx+70h],6
	je near ptr 00000001806B1914h
	cmp dword ptr [rbx+70h],15h
	je near ptr 00000001806B18F2h
	cmp dword ptr [rbx+70h],2Eh
	je near ptr 00000001806B18F2h
	cmp dword ptr [rbx+70h],4
	je near ptr 00000001806B18DCh
	cmp dword ptr [rbx+70h],16h
	je near ptr 00000001806B189Eh
	cmp dword ptr [rbx+70h],8
	je near ptr 00000001806B1860h
	cmp dword ptr [rbx+70h],18h
	je near ptr 00000001806B1860h
	cmp dword ptr [rbx+70h],0Ah
	je near ptr 00000001806B1822h
	cmp dword ptr [rbx+70h],2Ah
	je near ptr 00000001806B17DEh
	cmp dword ptr [rbx+70h],13h
	je short 00000001806B17C9h
	cmp dword ptr [rbx+70h],2Bh
	je short 00000001806B179Bh
	movss xmm0,dword ptr [rbx+20h]
	addss xmm0,dword ptr [183C33C68h]
	mov eax,[rbx+24h]
	mov [rdi+4],eax
	mov rax,rdi
	mov dword ptr [rdi+8],44480000h
	movss dword ptr [rdi],xmm0
	movd xmm0,dword ptr [rbx+2Ch]
	cvtdq2ps xmm0,xmm0
	movss dword ptr [rdi+0Ch],xmm0
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	mov dword ptr [rdi],0C4480000h
	mov rax,rdi
	mov dword ptr [rdi+4],0C4160000h
	mov dword ptr [rdi+8],44C80000h
	mov dword ptr [rdi+0Ch],44960000h
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	mov eax,[rbx+20h]
	movd xmm0,dword ptr [rbx+28h]
	mov [rdi],eax
	mov eax,[rbx+24h]
	mov [rdi+4],eax
	jmp near ptr 00000001806B19C3h
	movss xmm0,dword ptr [rbx+20h]
	mov rax,rdi
	subss xmm0,dword ptr [183C33DCCh]
	mov dword ptr [rdi+8],43700000h
	mov dword ptr [rdi+0Ch],43700000h
	movss dword ptr [rdi],xmm0
	movss xmm0,dword ptr [rbx+24h]
	subss xmm0,dword ptr [183C33DCCh]
	movss dword ptr [rdi+4],xmm0
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	movss xmm0,dword ptr [rbx+20h]
	addss xmm0,dword ptr [183C33C68h]
	mov eax,[rbx+24h]
	mov [rdi+4],eax
	mov rax,rdi
	mov dword ptr [rdi+8],43AA0000h
	movss dword ptr [rdi],xmm0
	movd xmm0,dword ptr [rbx+2Ch]
	cvtdq2ps xmm0,xmm0
	movss dword ptr [rdi+0Ch],xmm0
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	movss xmm0,dword ptr [rbx+20h]
	addss xmm0,dword ptr [183C33C68h]
	mov eax,[rbx+24h]
	mov [rdi+4],eax
	mov rax,rdi
	mov dword ptr [rdi+8],43660000h
	movss dword ptr [rdi],xmm0
	movd xmm0,dword ptr [rbx+2Ch]
	cvtdq2ps xmm0,xmm0
	movss dword ptr [rdi+0Ch],xmm0
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	movss xmm0,dword ptr [rbx+20h]
	addss xmm0,dword ptr [183C33DC8h]
	mov eax,[rbx+24h]
	mov [rdi+4],eax
	mov rax,rdi
	mov dword ptr [rdi+8],41F00000h
	movss dword ptr [rdi],xmm0
	movd xmm0,dword ptr [rbx+2Ch]
	cvtdq2ps xmm0,xmm0
	movss dword ptr [rdi+0Ch],xmm0
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	mov eax,[rbx+20h]
	mov [rdi],eax
	mov eax,[rbx+24h]
	mov [rdi+4],eax
	mov eax,[rbx+28h]
	sub eax,19h
	jmp near ptr 00000001806B19BFh
	mov eax,[rbx+24h]
	movss xmm0,dword ptr [rbx+20h]
	addss xmm0,dword ptr [183C33DBCh]
	mov [rdi+4],eax
	mov eax,[rbx+28h]
	sub eax,32h
	movss dword ptr [rdi],xmm0
	jmp near ptr 00000001806B19BFh
	movss xmm0,dword ptr [rbx+20h]
	addss xmm0,dword ptr [183C33DCCh]
	mov eax,[rbx+24h]
	mov [rdi+4],eax
	mov rax,rdi
	mov dword ptr [rdi+8],42200000h
	movss dword ptr [rdi],xmm0
	movd xmm0,dword ptr [rbx+2Ch]
	cvtdq2ps xmm0,xmm0
	movss dword ptr [rdi+0Ch],xmm0
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	mov eax,[rbx+24h]
	movss xmm0,dword ptr [rbx+20h]
	addss xmm0,dword ptr [183C33DBCh]
	mov [rdi+4],eax
	mov eax,[rbx+28h]
	sub eax,23h
	movss dword ptr [rdi],xmm0
	jmp short 00000001806B19BFh
	mov eax,[rbx+24h]
	movd xmm0,dword ptr [rbx+2Ch]
	mov [rdi+4],eax
	mov eax,[rbx+20h]
	cvtdq2ps xmm0,xmm0
	mov [rdi+8],eax
	mov rax,rdi
	mov dword ptr [rdi],0
	movss dword ptr [rdi+0Ch],xmm0
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	mov eax,[rbx+24h]
	xorps xmm0,xmm0
	movss xmm1,dword ptr [rbx+20h]
	mov [rdi+4],eax
	addss xmm1,xmm0
	mov eax,[rbx+28h]
	sub eax,14h
	movss dword ptr [rdi],xmm1
	movd xmm0,eax
	movd xmm1,dword ptr [rbx+2Ch]
	cvtdq2ps xmm1,xmm1
	cvtdq2ps xmm0,xmm0
	movss dword ptr [rdi+0Ch],xmm1
	movss dword ptr [rdi+8],xmm0
	mov rbx,[rsp+30h]
	mov rax,rdi
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rsi
	003 ShiftStack -8
	004 Move stack:0x0, rdi
	005 ShiftStack -32
	006 Move xmm0, 0
	007 Move rdi, rcx
	008 Move [rcx], xmm0
	009 Move rcx, [rdx+16]
	010 Move rsi, r8
	011 Move rbx, rdx
	012 Compare rcx, 0
	013 JumpIfEqual {235}
	014 Move rdx, 0
	015 Call GameplayActivity.IsWallnutBowlingLevel, rcx, rdx
	016 Compare rax, 0
	017 JumpIfNotEqual {214}
	018 Compare rsi, 1
	019 JumpIfNotEqual {38}
	020 Compare [rbx+112], 28
	021 JumpIfNotEqual {38}
	022 Move xmm0, [rbx+32]
	023 Add xmm0, xmm0, [0x183C33EE0]
	024 Move rax, [rbx+36]
	025 Move [rdi+4], rax
	026 Move rax, rdi
	027 Move [rdi], 0
	028 Move [rdi+8], xmm0
	029 Move xmm0, [rbx+44]
	030 Move xmm0, xmm0
	031 Move [rdi+12], xmm0
	032 Move rbx, stack:0x30
	033 Move rsi, stack:0x38
	034 ShiftStack 32
	035 Move rdi, stack:0x0
	036 ShiftStack 8
	037 Return rax
	038 Compare [rbx+112], 52
	039 JumpIfEqual {199}
	040 Compare [rbx+112], 17
	041 JumpIfEqual {191}
	042 Compare [rbx+112], 6
	043 JumpIfEqual {175}
	044 Compare [rbx+112], 21
	045 JumpIfEqual {167}
	046 Compare [rbx+112], 46
	047 JumpIfEqual {167}
	048 Compare [rbx+112], 4
	049 JumpIfEqual {160}
	050 Compare [rbx+112], 22
	051 JumpIfEqual {144}
	052 Compare [rbx+112], 8
	053 JumpIfEqual {128}
	054 Compare [rbx+112], 24
	055 JumpIfEqual {128}
	056 Compare [rbx+112], 10
	057 JumpIfEqual {112}
	058 Compare [rbx+112], 42
	059 JumpIfEqual {97}
	060 Compare [rbx+112], 19
	061 JumpIfEqual {91}
	062 Compare [rbx+112], 43
	063 JumpIfEqual {80}
	064 Move xmm0, [rbx+32]
	065 Add xmm0, xmm0, [0x183C33C68]
	066 Move rax, [rbx+36]
	067 Move [rdi+4], rax
	068 Move rax, rdi
	069 Move [rdi+8], 0x44480000
	070 Move [rdi], xmm0
	071 Move xmm0, [rbx+44]
	072 Move xmm0, xmm0
	073 Move [rdi+12], xmm0
	074 Move rbx, stack:0x30
	075 Move rsi, stack:0x38
	076 ShiftStack 32
	077 Move rdi, stack:0x0
	078 ShiftStack 8
	079 Return rax
	080 Move [rdi], 0xC4480000
	081 Move rax, rdi
	082 Move [rdi+4], 0xC4160000
	083 Move [rdi+8], 0x44C80000
	084 Move [rdi+12], 0x44960000
	085 Move rbx, stack:0x30
	086 Move rsi, stack:0x38
	087 ShiftStack 32
	088 Move rdi, stack:0x0
	089 ShiftStack 8
	090 Return rax
	091 Move rax, [rbx+32]
	092 Move xmm0, [rbx+40]
	093 Move [rdi], rax
	094 Move rax, [rbx+36]
	095 Move [rdi+4], rax
	096 Goto {223}
	097 Move xmm0, [rbx+32]
	098 Move rax, rdi
	099 Subtract xmm0, xmm0, [0x183C33DCC]
	100 Move [rdi+8], 0x43700000
	101 Move [rdi+12], 0x43700000
	102 Move [rdi], xmm0
	103 Move xmm0, [rbx+36]
	104 Subtract xmm0, xmm0, [0x183C33DCC]
	105 Move [rdi+4], xmm0
	106 Move rbx, stack:0x30
	107 Move rsi, stack:0x38
	108 ShiftStack 32
	109 Move rdi, stack:0x0
	110 ShiftStack 8
	111 Return rax
	112 Move xmm0, [rbx+32]
	113 Add xmm0, xmm0, [0x183C33C68]
	114 Move rax, [rbx+36]
	115 Move [rdi+4], rax
	116 Move rax, rdi
	117 Move [rdi+8], 0x43AA0000
	118 Move [rdi], xmm0
	119 Move xmm0, [rbx+44]
	120 Move xmm0, xmm0
	121 Move [rdi+12], xmm0
	122 Move rbx, stack:0x30
	123 Move rsi, stack:0x38
	124 ShiftStack 32
	125 Move rdi, stack:0x0
	126 ShiftStack 8
	127 Return rax
	128 Move xmm0, [rbx+32]
	129 Add xmm0, xmm0, [0x183C33C68]
	130 Move rax, [rbx+36]
	131 Move [rdi+4], rax
	132 Move rax, rdi
	133 Move [rdi+8], 0x43660000
	134 Move [rdi], xmm0
	135 Move xmm0, [rbx+44]
	136 Move xmm0, xmm0
	137 Move [rdi+12], xmm0
	138 Move rbx, stack:0x30
	139 Move rsi, stack:0x38
	140 ShiftStack 32
	141 Move rdi, stack:0x0
	142 ShiftStack 8
	143 Return rax
	144 Move xmm0, [rbx+32]
	145 Add xmm0, xmm0, [0x183C33DC8]
	146 Move rax, [rbx+36]
	147 Move [rdi+4], rax
	148 Move rax, rdi
	149 Move [rdi+8], 0x41F00000
	150 Move [rdi], xmm0
	151 Move xmm0, [rbx+44]
	152 Move xmm0, xmm0
	153 Move [rdi+12], xmm0
	154 Move rbx, stack:0x30
	155 Move rsi, stack:0x38
	156 ShiftStack 32
	157 Move rdi, stack:0x0
	158 ShiftStack 8
	159 Return rax
	160 Move rax, [rbx+32]
	161 Move [rdi], rax
	162 Move rax, [rbx+36]
	163 Move [rdi+4], rax
	164 Move rax, [rbx+40]
	165 Subtract rax, rax, 25
	166 Goto {222}
	167 Move rax, [rbx+36]
	168 Move xmm0, [rbx+32]
	169 Add xmm0, xmm0, [0x183C33DBC]
	170 Move [rdi+4], rax
	171 Move rax, [rbx+40]
	172 Subtract rax, rax, 50
	173 Move [rdi], xmm0
	174 Goto {222}
	175 Move xmm0, [rbx+32]
	176 Add xmm0, xmm0, [0x183C33DCC]
	177 Move rax, [rbx+36]
	178 Move [rdi+4], rax
	179 Move rax, rdi
	180 Move [rdi+8], 0x42200000
	181 Move [rdi], xmm0
	182 Move xmm0, [rbx+44]
	183 Move xmm0, xmm0
	184 Move [rdi+12], xmm0
	185 Move rbx, stack:0x30
	186 Move rsi, stack:0x38
	187 ShiftStack 32
	188 Move rdi, stack:0x0
	189 ShiftStack 8
	190 Return rax
	191 Move rax, [rbx+36]
	192 Move xmm0, [rbx+32]
	193 Add xmm0, xmm0, [0x183C33DBC]
	194 Move [rdi+4], rax
	195 Move rax, [rbx+40]
	196 Subtract rax, rax, 35
	197 Move [rdi], xmm0
	198 Goto {222}
	199 Move rax, [rbx+36]
	200 Move xmm0, [rbx+44]
	201 Move [rdi+4], rax
	202 Move rax, [rbx+32]
	203 Move xmm0, xmm0
	204 Move [rdi+8], rax
	205 Move rax, rdi
	206 Move [rdi], 0
	207 Move [rdi+12], xmm0
	208 Move rbx, stack:0x30
	209 Move rsi, stack:0x38
	210 ShiftStack 32
	211 Move rdi, stack:0x0
	212 ShiftStack 8
	213 Return rax
	214 Move rax, [rbx+36]
	215 Move xmm0, 0
	216 Move xmm1, [rbx+32]
	217 Move [rdi+4], rax
	218 Add xmm1, xmm1, xmm0
	219 Move rax, [rbx+40]
	220 Subtract rax, rax, 20
	221 Move [rdi], xmm1
	222 Move xmm0, rax
	223 Move xmm1, [rbx+44]
	224 Move xmm1, xmm1
	225 Move xmm0, xmm0
	226 Move [rdi+12], xmm1
	227 Move [rdi+8], xmm0
	228 Move rbx, stack:0x30
	229 Move rax, rdi
	230 Move rsi, stack:0x38
	231 ShiftStack 32
	232 Move rdi, stack:0x0
	233 ShiftStack 8
	234 Return rax
	235 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
