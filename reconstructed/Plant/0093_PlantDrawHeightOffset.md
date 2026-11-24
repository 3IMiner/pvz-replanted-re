# System.Single PlantDrawHeightOffset(Reloaded.TreeStateActivities.GameplayActivity app, Reloaded.Gameplay.Board theBoard, Reloaded.Gameplay.Plant thePlant, Reloaded.Gameplay.SeedType theSeedType, System.Int32 theCol, System.Int32 theRow)

- 类：`Plant`
- 汇编行数：537

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rbp
	mov [rsp+18h],rsi
	push rdi
	push r14
	push r15
	sub rsp,40h
	mov r14d,[rsp+88h]
	mov rsi,r8
	mov ebp,[rsp+80h]
	mov rdi,rdx
	movaps [rsp+30h],xmm6
	mov r15,rcx
	movsxd rbx,r9d
	xorps xmm6,xmm6
	movaps [rsp+20h],xmm7
	xorps xmm7,xmm7
	cmp ebx,23h
	je near ptr 00000001806B34F1h
	test rdx,rdx
	je short 00000001806B344Ch
	xor r9d,r9d
	mov r8d,r14d
	mov edx,ebp
	mov rcx,rdi
	call 0000000180662110h
	test al,al
	jne short 00000001806B3444h
	test rsi,rsi
	je near ptr 00000001806B3509h
	cmp dword ptr [rdi+1B4h],8
	jne near ptr 00000001806B34FFh
	cmp ebp,5
	jge near ptr 00000001806B34FFh
	mov eax,[rdi+1ECh]
	jmp short 00000001806B346Bh
	cmp ebx,18h
	ja short 00000001806B345Bh
	mov eax,1090000h
	bt eax,ebx
	jb short 00000001806B3464h
	cmp ebx,2Bh
	jne near ptr 00000001806B35FDh
	xor ecx,ecx
	call 0000000183840220h
	cmp byte ptr [184EEB632h],0
	xorps xmm6,xmm6
	xorps xmm1,xmm1
	xorps xmm0,xmm0
	cvtsi2ss xmm6,ebp
	cvtsi2ss xmm1,eax
	mulss xmm6,dword ptr [183C33F98h]
	mulss xmm1,dword ptr [183C33E24h]
	cvtsi2ss xmm0,r14d
	divss xmm1,dword ptr [183C33FFCh]
	mulss xmm0,dword ptr [183C33ED0h]
	addss xmm6,xmm0
	addss xmm6,xmm1
	jne short 00000001806B34C5h
	lea rcx,[184CAAE68h]
	call 00000001804FEB70h
	mov byte ptr [184EEB632h],1
	mov rcx,[184CAAE68h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B34DAh
	call 00000001804FEEB0h
	cvtps2pd xmm0,xmm6
	call 00000001805DA2D0h
	xorps xmm6,xmm6
	cvtsd2ss xmm6,xmm0
	addss xmm6,xmm6
	addss xmm6,xmm7
	test rdi,rdi
	je near ptr 00000001806B35FDh
	test rsi,rsi
	je short 00000001806B3509h
	cmp byte ptr [rsi+3Ch],0
	jne near ptr 00000001806B35FDh
	xor r9d,r9d
	mov r8d,r14d
	mov edx,ebp
	mov rcx,rdi
	call 000000018065DE10h
	test rax,rax
	je near ptr 00000001806B35FDh
	cmp byte ptr [rax+3Ch],0
	jne near ptr 00000001806B35FDh
	cmp ebx,21h
	je near ptr 00000001806B3785h
	movss xmm2,dword ptr [183C33F28h]
	xorps xmm1,xmm1
	cmp ebx,6
	je near ptr 00000001806B35DDh
	cmp ebx,19h
	je near ptr 00000001806B35DDh
	cmp ebx,0Dh
	je short 00000001806B35D0h
	cmp ebx,9
	je short 00000001806B35C6h
	cmp ebx,8
	je short 00000001806B35C6h
	cmp ebx,0Ch
	je short 00000001806B35D3h
	cmp ebx,1Fh
	je short 00000001806B35D3h
	cmp ebx,34h
	ja short 00000001806B3580h
	mov rcx,100000000400A3h
	bt rcx,rbx
	jb short 00000001806B35D3h
	cmp ebx,26h
	je short 00000001806B35D3h
	cmp ebx,20h
	je short 00000001806B35D3h
	cmp ebx,27h
	je short 00000001806B35D3h
	cmp ebx,13h
	je short 00000001806B35D3h
	cmp ebx,1Bh
	je short 00000001806B35D3h
	cmp ebx,15h
	je short 00000001806B35D3h
	cmp ebx,18h
	je short 00000001806B35C6h
	cmp ebx,4
	je short 00000001806B35C6h
	cmp ebx,10h
	je short 00000001806B35BCh
	cmp ebx,23h
	jne short 00000001806B35E5h
	movss xmm1,dword ptr [183C33F48h]
	jmp short 00000001806B35E5h
	movss xmm1,dword ptr [183C34014h]
	jmp short 00000001806B35E5h
	movss xmm1,dword ptr [183C34008h]
	jmp short 00000001806B35E5h
	xorps xmm2,xmm2
	movss xmm1,dword ptr [183C33F30h]
	jmp short 00000001806B35E5h
	movss xmm2,dword ptr [183C33F38h]
	movaps xmm0,xmm1
	xorps xmm0,[183C33CA0h]
	addss xmm0,xmm1
	addss xmm0,xmm2
	addss xmm6,xmm0
	jmp short 00000001806B3606h
	cmp ebx,21h
	je near ptr 00000001806B3785h
	cmp ebx,10h
	je near ptr 00000001806B377Bh
	cmp ebx,1Dh
	je near ptr 00000001806B3771h
	cmp ebx,13h
	je near ptr 00000001806B3767h
	cmp ebx,18h
	je near ptr 00000001806B375Dh
	cmp ebx,23h
	je near ptr 00000001806B3753h
	cmp ebx,1Ah
	je near ptr 00000001806B378Dh
	cmp ebx,1Eh
	je near ptr 00000001806B3735h
	cmp ebx,8
	je short 00000001806B36C7h
	cmp ebx,0Dh
	je near ptr 00000001806B3749h
	cmp ebx,0Bh
	je near ptr 00000001806B373Fh
	cmp ebx,15h
	je short 00000001806B366Ah
	cmp ebx,2Eh
	jne near ptr 00000001806B378Dh
	mov esi,4
	test rdi,rdi
	je short 00000001806B3688h
	xor edx,edx
	mov rcx,rdi
	call 0000000180671820h
	test al,al
	mov ecx,5
	cmovne esi,ecx
	cmp ebx,2Eh
	jne short 00000001806B3695h
	addss xmm6,dword ptr [183C33DA0h]
	test rdi,rdi
	je short 00000001806B36FFh
	xor r9d,r9d
	mov r8d,r14d
	mov edx,ebp
	mov rcx,rdi
	call 000000018065DE10h
	test rax,rax
	je short 00000001806B36D4h
	test r15,r15
	je near ptr 00000001806B37B3h
	xor edx,edx
	mov rcx,r15
	call 00000001807E3010h
	cmp eax,2Bh
	je short 00000001806B36D4h
	addss xmm6,dword ptr [183C33ED4h]
	jmp near ptr 00000001806B378Dh
	xor edx,edx
	mov rcx,rdi
	call 00000001806719C0h
	test al,al
	jne short 00000001806B3735h
	xor r9d,r9d
	mov r8d,r14d
	mov edx,ebp
	mov rcx,rdi
	call 0000000180662110h
	test al,al
	je short 00000001806B36FFh
	addss xmm6,xmm7
	jmp near ptr 00000001806B378Dh
	cmp r14d,esi
	jne short 00000001806B3735h
	cmp ebp,7
	jl short 00000001806B372Bh
	test rdi,rdi
	je short 00000001806B3735h
	xor edx,edx
	mov rcx,rdi
	call 0000000180671820h
	test al,al
	je short 00000001806B3726h
	addss xmm6,dword ptr [183C33C4Ch]
	jmp short 00000001806B378Dh
	cmp ebp,7
	jge short 00000001806B3735h
	addss xmm6,dword ptr [183C33DB4h]
	jmp short 00000001806B378Dh
	addss xmm6,dword ptr [183C33DB8h]
	jmp short 00000001806B378Dh
	addss xmm6,dword ptr [183C33F5Ch]
	jmp short 00000001806B378Dh
	addss xmm6,dword ptr [183C34010h]
	jmp short 00000001806B378Dh
	addss xmm6,dword ptr [183C33F48h]
	jmp short 00000001806B378Dh
	addss xmm6,dword ptr [183C33FB8h]
	jmp short 00000001806B378Dh
	addss xmm6,dword ptr [183C33EF0h]
	jmp short 00000001806B378Dh
	addss xmm6,dword ptr [183C33DACh]
	jmp short 00000001806B378Dh
	addss xmm6,dword ptr [183C33DC0h]
	jmp short 00000001806B378Dh
	addss xmm6,dword ptr [183C33FB0h]
	mov rbx,[rsp+60h]
	movaps xmm0,xmm6
	movaps xmm6,[rsp+30h]
	mov rbp,[rsp+68h]
	mov rsi,[rsp+70h]
	movaps xmm7,[rsp+20h]
	add rsp,40h
	pop r15
	pop r14
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rbp
	003 Move stack:0x18, rsi
	004 ShiftStack -8
	005 Move stack:0x0, rdi
	006 ShiftStack -8
	007 Move stack:0x0, r14
	008 ShiftStack -8
	009 Move stack:0x0, r15
	010 ShiftStack -64
	011 Move r14, stack:0x88
	012 Move rsi, r8
	013 Move rbp, stack:0x80
	014 Move rdi, rdx
	015 Move stack:0x30, xmm6
	016 Move r15, rcx
	017 Move rbx, r9
	018 Move xmm6, 0
	019 Move stack:0x20, xmm7
	020 Move xmm7, 0
	021 Compare rbx, 35
	022 JumpIfEqual {76}
	023 Compare rdx, 0
	024 JumpIfEqual {40}
	025 Move r9, 0
	026 Move r8, r14
	027 Move rdx, rbp
	028 Move rcx, rdi
	029 Call Board.IsPoolSquare, rcx, rdx, r8
	030 Compare rax, 0
	031 JumpIfNotEqual {38}
	032 Compare rsi, 0
	033 JumpIfEqual {82}
	034 Compare [rdi+436], 8
	035 JumpIfNotEqual {80}
	036 Compare rbp, 5
	037 JumpIfGreaterOrEqual {80}
	038 Move rax, [rdi+492]
	039 Goto {49}
	040 Compare rbx, 24
	041 JumpIfGreater {45}
	042 Move rax, 0x1090000
	043 NotImplemented "bt eax,ebx"
	044 JumpIfLess {47}
	045 Compare rbx, 43
	046 JumpIfNotEqual {150}
	047 Move rcx, 0
	048 Call Time.get_frameCount, rcx
	049 Compare [0x184EEB632], 0
	050 Move xmm6, 0
	051 Move xmm1, 0
	052 Move xmm0, 0
	053 NotImplemented "cvtsi2ss xmm6,ebp"
	054 NotImplemented "cvtsi2ss xmm1,eax"
	055 Multiply xmm6, xmm6, [0x183C33F98]
	056 Multiply xmm1, xmm1, [0x183C33E24]
	057 NotImplemented "cvtsi2ss xmm0,r14d"
	058 Divide xmm1, xmm1, [0x183C33FFC]
	059 Multiply xmm0, xmm0, [0x183C33ED0]
	060 Add xmm6, xmm6, xmm0
	061 Add xmm6, xmm6, xmm1
	062 JumpIfNotEqual {66}
	063 LoadAddress rcx, [0x184CAAE68]
	064 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	065 Move [0x184EEB632], 1
	066 Move rcx, typeof(System.Math)
	067 Compare [rcx+228], 0
	068 JumpIfNotEqual {70}
	069 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	070 Move xmm0, xmm6
	071 Call 0x1805DA2D0, rcx, rdx, r8, r9
	072 Move xmm6, 0
	073 NotImplemented "cvtsd2ss xmm6,xmm0"
	074 Add xmm6, xmm6, xmm6
	075 Add xmm6, xmm6, xmm7
	076 Compare rdi, 0
	077 JumpIfEqual {150}
	078 Compare rsi, 0
	079 JumpIfEqual {82}
	080 Compare [rsi+60], 0
	081 JumpIfNotEqual {150}
	082 Move r9, 0
	083 Move r8, r14
	084 Move rdx, rbp
	085 Move rcx, rdi
	086 Call Board.GetFlowerPotAt, rcx, rdx, r8
	087 Compare rax, 0
	088 JumpIfEqual {150}
	089 Compare [rax+60], 0
	090 JumpIfNotEqual {150}
	091 Compare rbx, 33
	092 JumpIfEqual {255}
	093 Move xmm2, [0x183C33F28]
	094 Move xmm1, 0
	095 Compare rbx, 6
	096 JumpIfEqual {143}
	097 Compare rbx, 25
	098 JumpIfEqual {143}
	099 Compare rbx, 13
	100 JumpIfEqual {140}
	101 Compare rbx, 9
	102 JumpIfEqual {138}
	103 Compare rbx, 8
	104 JumpIfEqual {138}
	105 Compare rbx, 12
	106 JumpIfEqual {141}
	107 Compare rbx, 31
	108 JumpIfEqual {141}
	109 Compare rbx, 52
	110 JumpIfGreater {114}
	111 Move rcx, 0x100000000400A3
	112 NotImplemented "bt rcx,rbx"
	113 JumpIfLess {141}
	114 Compare rbx, 38
	115 JumpIfEqual {141}
	116 Compare rbx, 32
	117 JumpIfEqual {141}
	118 Compare rbx, 39
	119 JumpIfEqual {141}
	120 Compare rbx, 19
	121 JumpIfEqual {141}
	122 Compare rbx, 27
	123 JumpIfEqual {141}
	124 Compare rbx, 21
	125 JumpIfEqual {141}
	126 Compare rbx, 24
	127 JumpIfEqual {138}
	128 Compare rbx, 4
	129 JumpIfEqual {138}
	130 Compare rbx, 16
	131 JumpIfEqual {136}
	132 Compare rbx, 35
	133 JumpIfNotEqual {144}
	134 Move xmm1, [0x183C33F48]
	135 Goto {144}
	136 Move xmm1, [0x183C34014]
	137 Goto {144}
	138 Move xmm1, [0x183C34008]
	139 Goto {144}
	140 Move xmm2, 0
	141 Move xmm1, [0x183C33F30]
	142 Goto {144}
	143 Move xmm2, [0x183C33F38]
	144 Move xmm0, xmm1
	145 Xor xmm0, xmm0, [0x183C33CA0]
	146 Add xmm0, xmm0, xmm1
	147 Add xmm0, xmm0, xmm2
	148 Add xmm6, xmm6, xmm0
	149 Goto {152}
	150 Compare rbx, 33
	151 JumpIfEqual {255}
	152 Compare rbx, 16
	153 JumpIfEqual {253}
	154 Compare rbx, 29
	155 JumpIfEqual {251}
	156 Compare rbx, 19
	157 JumpIfEqual {249}
	158 Compare rbx, 24
	159 JumpIfEqual {247}
	160 Compare rbx, 35
	161 JumpIfEqual {245}
	162 Compare rbx, 26
	163 JumpIfEqual {256}
	164 Compare rbx, 30
	165 JumpIfEqual {239}
	166 Compare rbx, 8
	167 JumpIfEqual {206}
	168 Compare rbx, 13
	169 JumpIfEqual {243}
	170 Compare rbx, 11
	171 JumpIfEqual {241}
	172 Compare rbx, 21
	173 JumpIfEqual {176}
	174 Compare rbx, 46
	175 JumpIfNotEqual {256}
	176 Move rsi, 4
	177 Compare rdi, 0
	178 JumpIfEqual {187}
	179 Move rdx, 0
	180 Move rcx, rdi
	181 Call 0x180671820, rcx, rdx
	182 Compare rax, 0
	183 Move rcx, 5
	184 JumpIfEqual {186}
	185 Move rsi, rcx
	186 Nop 
	187 Compare rbx, 46
	188 JumpIfNotEqual {190}
	189 Add xmm6, xmm6, [0x183C33DA0]
	190 Compare rdi, 0
	191 JumpIfEqual {222}
	192 Move r9, 0
	193 Move r8, r14
	194 Move rdx, rbp
	195 Move rcx, rdi
	196 Call Board.GetFlowerPotAt, rcx, rdx, r8
	197 Compare rax, 0
	198 JumpIfEqual {208}
	199 Compare r15, 0
	200 JumpIfEqual {270}
	201 Move rdx, 0
	202 Move rcx, r15
	203 Call GameplayActivity.get_GameMode, rcx, rdx
	204 Compare rax, 43
	205 JumpIfEqual {208}
	206 Add xmm6, xmm6, [0x183C33ED4]
	207 Goto {256}
	208 Move rdx, 0
	209 Move rcx, rdi
	210 Call Board.StageHasRoof, rcx, rdx
	211 Compare rax, 0
	212 JumpIfNotEqual {239}
	213 Move r9, 0
	214 Move r8, r14
	215 Move rdx, rbp
	216 Move rcx, rdi
	217 Call Board.IsPoolSquare, rcx, rdx, r8
	218 Compare rax, 0
	219 JumpIfEqual {222}
	220 Add xmm6, xmm6, xmm7
	221 Goto {256}
	222 Compare r14, rsi
	223 JumpIfNotEqual {239}
	224 Compare rbp, 7
	225 JumpIfLess {237}
	226 Compare rdi, 0
	227 JumpIfEqual {239}
	228 Move rdx, 0
	229 Move rcx, rdi
	230 Call 0x180671820, rcx, rdx
	231 Compare rax, 0
	232 JumpIfEqual {235}
	233 Add xmm6, xmm6, [0x183C33C4C]
	234 Goto {256}
	235 Compare rbp, 7
	236 JumpIfGreaterOrEqual {239}
	237 Add xmm6, xmm6, [0x183C33DB4]
	238 Goto {256}
	239 Add xmm6, xmm6, [0x183C33DB8]
	240 Goto {256}
	241 Add xmm6, xmm6, [0x183C33F5C]
	242 Goto {256}
	243 Add xmm6, xmm6, [0x183C34010]
	244 Goto {256}
	245 Add xmm6, xmm6, [0x183C33F48]
	246 Goto {256}
	247 Add xmm6, xmm6, [0x183C33FB8]
	248 Goto {256}
	249 Add xmm6, xmm6, [0x183C33EF0]
	250 Goto {256}
	251 Add xmm6, xmm6, [0x183C33DAC]
	252 Goto {256}
	253 Add xmm6, xmm6, [0x183C33DC0]
	254 Goto {256}
	255 Add xmm6, xmm6, [0x183C33FB0]
	256 Move rbx, stack:0x60
	257 Move xmm0, xmm6
	258 Move xmm6, stack:0x30
	259 Move rbp, stack:0x68
	260 Move rsi, stack:0x70
	261 Move xmm7, stack:0x20
	262 ShiftStack 64
	263 Move r15, stack:0x0
	264 ShiftStack 8
	265 Move r14, stack:0x0
	266 ShiftStack 8
	267 Move rdi, stack:0x0
	268 ShiftStack 8
	269 Return xmm0
	270 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
