# System.Void UpdateProductionPlant()

- 类：`Plant`
- 汇编行数：483

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,40h
	cmp byte ptr [184EEB63Eh],0
	mov rbx,rcx
	jne short 00000001806BAD01h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	mov byte ptr [184EEB63Eh],1
	cmp qword ptr [rbx+18h],0
	je near ptr 00000001806BB0C3h
	cmp byte ptr [rbx+137h],0
	je near ptr 00000001806BB0C3h
	mov [rsp+58h],rsi
	mov [rsp+60h],rdi
	mov [rsp+68h],r14
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BB0E7h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,2Bh
	je near ptr 00000001806BB0B4h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BB0E7h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,32h
	je near ptr 00000001806BB0B4h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BB0E7h
	xor edx,edx
	call 00000001807DF5D0h
	test al,al
	jne near ptr 00000001806BB0B4h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BB0E7h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,47h
	je near ptr 00000001806BB0B4h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BB0E7h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,48h
	je near ptr 00000001806BB0B4h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BB0E7h
	xor edx,edx
	call 000000018065F8A0h
	test al,al
	jne near ptr 00000001806BB0B4h
	cmp dword ptr [rbx+70h],26h
	jne short 00000001806BAE20h
	mov rdx,[rbx+18h]
	test rdx,rdx
	je near ptr 00000001806BB0E7h
	mov ecx,[rdx+1E8h]
	cmp [rdx+200h],ecx
	jne short 00000001806BAE20h
	cmp dword ptr [rbx+88h],2Eh
	jne short 00000001806BAE0Ch
	cmp dword ptr [rbx+0A0h],0
	jne short 00000001806BAE20h
	jmp near ptr 00000001806BB0B4h
	mov dword ptr [rbx+88h],2Eh
	mov dword ptr [rbx+0A0h],1770h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BB0E7h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,1Fh
	jne short 00000001806BAE60h
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806BB0E7h
	mov rcx,[rax+110h]
	test rcx,rcx
	je near ptr 00000001806BB0E7h
	cmp dword ptr [rcx+54h],0Ah
	jne near ptr 00000001806BB0B4h
	mov esi,[rbx+0A4h]
	mov rax,[rbx+10h]
	dec esi
	mov [rbx+0A4h],esi
	test rax,rax
	je near ptr 00000001806BB0E7h
	mov rcx,[rax+0C8h]
	xor r14d,r14d
	test rcx,rcx
	je short 00000001806BAE93h
	movzx edi,byte ptr [rcx+82h]
	jmp short 00000001806BAE96h
	mov edi,r14d
	cmp esi,64h
	jg short 00000001806BAEF2h
	test edi,edi
	je short 00000001806BAEA5h
	cmp dword ptr [rbx+70h],26h
	jne short 00000001806BAEF2h
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r14d
	jne short 00000001806BAEBAh
	call 00000001804FEEB0h
	mov [rsp+30h],r14
	xor r9d,r9d
	mov dword ptr [rsp+28h],1
	mov r8d,esi
	xor edx,edx
	mov dword ptr [rsp+20h],64h
	mov ecx,64h
	call 00000001806CC120h
	mov ecx,[rbx+104h]
	cmp ecx,eax
	cmovg eax,ecx
	mov [rbx+104h],eax
	cmp [rbx+0A4h],r14d
	jg near ptr 00000001806BB0B4h
	mov rcx,[184C2AFC0h]
	mov esi,[rbx+0A8h]
	mov [rsp+50h],rbp
	cmp [rcx+0E4h],r14d
	jne short 00000001806BAF1Fh
	call 00000001804FEEB0h
	lea ecx,[rsi-96h]
	xor r8d,r8d
	mov edx,esi
	call 00000001806CBDF0h
	mov r8,[rbx+10h]
	mov rbp,[rsp+50h]
	mov [rbx+0A4h],eax
	test r8,r8
	je near ptr 00000001806BB0E7h
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806BB0E7h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,4
	call 0000000180002040h
	test edi,edi
	jne near ptr 00000001806BB00Bh
	cmp dword ptr [rbx+70h],9
	je short 00000001806BAFCDh
	cmp dword ptr [rbx+70h],1
	je short 00000001806BAFB8h
	cmp dword ptr [rbx+70h],29h
	jne near ptr 00000001806BB00Bh
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BB0E7h
	movss xmm2,dword ptr [rbx+24h]
	mov r9d,4
	movss xmm1,dword ptr [rbx+20h]
	mov [rsp+28h],r14
	mov dword ptr [rsp+20h],2
	call 0000000180654EA0h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BB0E7h
	mov r9d,4
	jmp short 00000001806BAFEFh
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BB0E7h
	cmp dword ptr [rbx+88h],17h
	mov r9d,4
	jne short 00000001806BAFEFh
	mov r9d,5
	movss xmm2,dword ptr [rbx+24h]
	movss xmm1,dword ptr [rbx+20h]
	mov [rsp+28h],r14
	mov dword ptr [rsp+20h],2
	call 0000000180654EA0h
	cmp dword ptr [rbx+70h],26h
	jne short 00000001806BB068h
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r14d
	jne short 00000001806BB026h
	call 00000001804FEEB0h
	xor edx,edx
	mov ecx,64h
	call 00000001806CBE80h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BB0E7h
	movss xmm2,dword ptr [rbx+24h]
	mov r9d,r14d
	movss xmm1,dword ptr [rbx+20h]
	cmp eax,0Ah
	mov [rsp+28h],r14
	setl r9b
	mov dword ptr [rsp+20h],3
	inc r9d
	call 0000000180654EA0h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806BB0E7h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,27h
	jne short 00000001806BB0B4h
	cmp dword ptr [rbx+70h],1
	je short 00000001806BB0C9h
	cmp dword ptr [rbx+70h],26h
	jne short 00000001806BB0B4h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je short 00000001806BB0E7h
	mov [rsp+28h],r14
	mov r9d,1
	mov dword ptr [rsp+20h],3
	movss xmm2,dword ptr [rbx+24h]
	movss xmm1,dword ptr [rbx+20h]
	call 0000000180654EA0h
	mov rdi,[rsp+60h]
	mov rsi,[rsp+58h]
	mov r14,[rsp+68h]
	add rsp,40h
	pop rbx
	ret
	mov rcx,[rbx+18h]
	test rcx,rcx
	je short 00000001806BB0E7h
	mov [rsp+28h],r14
	mov r9d,4
	mov dword ptr [rsp+20h],2
	jmp short 00000001806BB0A5h
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -64
	004 Compare [0x184EEB63E], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {12}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C75168]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 Move [0x184EEB63E], 1
	012 Compare [rbx+24], 0
	013 JumpIfEqual {230}
	014 Compare [rbx+311], 0
	015 JumpIfEqual {230}
	016 Move stack:0x58, rsi
	017 Move stack:0x60, rdi
	018 Move stack:0x68, r14
	019 Move rcx, [rbx+16]
	020 Compare rcx, 0
	021 JumpIfEqual {241}
	022 Move rdx, 0
	023 Call GameplayActivity.get_GameMode, rcx, rdx
	024 Compare rax, 43
	025 JumpIfEqual {227}
	026 Move rcx, [rbx+16]
	027 Compare rcx, 0
	028 JumpIfEqual {241}
	029 Move rdx, 0
	030 Call GameplayActivity.get_GameMode, rcx, rdx
	031 Compare rax, 50
	032 JumpIfEqual {227}
	033 Move rcx, [rbx+16]
	034 Compare rcx, 0
	035 JumpIfEqual {241}
	036 Move rdx, 0
	037 Call GameplayActivity.IsIZombieLevel, rcx, rdx
	038 Compare rax, 0
	039 JumpIfNotEqual {227}
	040 Move rcx, [rbx+16]
	041 Compare rcx, 0
	042 JumpIfEqual {241}
	043 Move rdx, 0
	044 Call GameplayActivity.get_GameMode, rcx, rdx
	045 Compare rax, 71
	046 JumpIfEqual {227}
	047 Move rcx, [rbx+16]
	048 Compare rcx, 0
	049 JumpIfEqual {241}
	050 Move rdx, 0
	051 Call GameplayActivity.get_GameMode, rcx, rdx
	052 Compare rax, 72
	053 JumpIfEqual {227}
	054 Move rcx, [rbx+24]
	055 Compare rcx, 0
	056 JumpIfEqual {241}
	057 Move rdx, 0
	058 Call Board.HasLevelAwardDropped, rcx, rdx
	059 Compare rax, 0
	060 JumpIfNotEqual {227}
	061 Compare [rbx+112], 38
	062 JumpIfNotEqual {76}
	063 Move rdx, [rbx+24]
	064 Compare rdx, 0
	065 JumpIfEqual {241}
	066 Move rcx, [rdx+488]
	067 Compare [rdx+512], rcx
	068 JumpIfNotEqual {76}
	069 Compare [rbx+136], 46
	070 JumpIfNotEqual {74}
	071 Compare [rbx+160], 0
	072 JumpIfNotEqual {76}
	073 Goto {227}
	074 Move [rbx+136], 46
	075 Move [rbx+160], 0x1770
	076 Move rcx, [rbx+16]
	077 Compare rcx, 0
	078 JumpIfEqual {241}
	079 Move rdx, 0
	080 Call GameplayActivity.get_GameMode, rcx, rdx
	081 Compare rax, 31
	082 JumpIfNotEqual {91}
	083 Move rax, [rbx+24]
	084 Compare rax, 0
	085 JumpIfEqual {241}
	086 Move rcx, [rax+272]
	087 Compare rcx, 0
	088 JumpIfEqual {241}
	089 Compare [rcx+84], 10
	090 JumpIfNotEqual {227}
	091 Move rsi, [rbx+164]
	092 Move rax, [rbx+16]
	093 Subtract rsi, rsi, 1
	094 Move [rbx+164], rsi
	095 Compare rax, 0
	096 JumpIfEqual {241}
	097 Move rcx, [rax+200]
	098 Move r14, 0
	099 Compare rcx, 0
	100 JumpIfEqual {103}
	101 Move rdi, [rcx+130]
	102 Goto {104}
	103 Move rdi, r14
	104 Compare rsi, 100
	105 JumpIfGreater {128}
	106 Compare rdi, 0
	107 JumpIfEqual {110}
	108 Compare [rbx+112], 38
	109 JumpIfNotEqual {128}
	110 Move rcx, typeof(Reloaded.Gameplay.Common)
	111 Compare [rcx+228], r14
	112 JumpIfNotEqual {114}
	113 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	114 Move stack:0x30, r14
	115 Move r9, 0
	116 Move stack:0x28, 1
	117 Move r8, rsi
	118 Move rdx, 0
	119 Move stack:0x20, 100
	120 Move rcx, 100
	121 Call Common.TodAnimateCurve, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	122 Move rcx, [rbx+260]
	123 Compare rcx, rax
	124 JumpIfLessOrEqual {126}
	125 Move rax, rcx
	126 Nop 
	127 Move [rbx+260], rax
	128 Compare [rbx+164], r14
	129 JumpIfGreater {227}
	130 Move rcx, typeof(Reloaded.Gameplay.Common)
	131 Move rsi, [rbx+168]
	132 Move stack:0x50, rbp
	133 Compare [rcx+228], r14
	134 JumpIfNotEqual {136}
	135 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	136 LoadAddress rcx, [rsi-150]
	137 Move r8, 0
	138 Move rdx, rsi
	139 Call Common.RandRangeInt, rcx, rdx, r8
	140 Move r8, [rbx+16]
	141 Move rbp, stack:0x50
	142 Move [rbx+164], rax
	143 Compare r8, 0
	144 JumpIfEqual {241}
	145 Move r8, [r8+88]
	146 Compare r8, 0
	147 JumpIfEqual {241}
	148 Move rdx, typeof(Reloaded.Services.IAudioService)
	149 Move rcx, 6
	150 Move r9, 4
	151 Call 0x180002040, rcx, rdx, r8, r9
	152 Compare rdi, 0
	153 JumpIfNotEqual {186}
	154 Compare [rbx+112], 9
	155 JumpIfEqual {174}
	156 Compare [rbx+112], 1
	157 JumpIfEqual {169}
	158 Compare [rbx+112], 41
	159 JumpIfNotEqual {186}
	160 Move rcx, [rbx+24]
	161 Compare rcx, 0
	162 JumpIfEqual {241}
	163 Move xmm2, [rbx+36]
	164 Move r9, 4
	165 Move xmm1, [rbx+32]
	166 Move stack:0x28, r14
	167 Move stack:0x20, 2
	168 Call Board.AddCoin, rcx, xmm1, r8, r9, stack:0x0
	169 Move rcx, [rbx+24]
	170 Compare rcx, 0
	171 JumpIfEqual {241}
	172 Move r9, 4
	173 Goto {181}
	174 Move rcx, [rbx+24]
	175 Compare rcx, 0
	176 JumpIfEqual {241}
	177 Compare [rbx+136], 23
	178 Move r9, 4
	179 JumpIfNotEqual {181}
	180 Move r9, 5
	181 Move xmm2, [rbx+36]
	182 Move xmm1, [rbx+32]
	183 Move stack:0x28, r14
	184 Move stack:0x20, 2
	185 Call Board.AddCoin, rcx, xmm1, r8, r9, stack:0x0
	186 Compare [rbx+112], 38
	187 JumpIfNotEqual {207}
	188 Move rcx, typeof(Reloaded.Gameplay.Common)
	189 Compare [rcx+228], r14
	190 JumpIfNotEqual {192}
	191 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	192 Move rdx, 0
	193 Move rcx, 100
	194 Call Common.Rand, rcx, rdx
	195 Move rcx, [rbx+24]
	196 Compare rcx, 0
	197 JumpIfEqual {241}
	198 Move xmm2, [rbx+36]
	199 Move r9, r14
	200 Move xmm1, [rbx+32]
	201 Compare rax, 10
	202 Move stack:0x28, r14
	203 NotImplemented "setl r9b"
	204 Move stack:0x20, 3
	205 Add r9, r9, 1
	206 Call Board.AddCoin, rcx, xmm1, r8, r9, stack:0x0
	207 Move rcx, [rbx+16]
	208 Compare rcx, 0
	209 JumpIfEqual {241}
	210 Move rdx, 0
	211 Call GameplayActivity.get_GameMode, rcx, rdx
	212 Compare rax, 39
	213 JumpIfNotEqual {227}
	214 Compare [rbx+112], 1
	215 JumpIfEqual {234}
	216 Compare [rbx+112], 38
	217 JumpIfNotEqual {227}
	218 Move rcx, [rbx+24]
	219 Compare rcx, 0
	220 JumpIfEqual {241}
	221 Move stack:0x28, r14
	222 Move r9, 1
	223 Move stack:0x20, 3
	224 Move xmm2, [rbx+36]
	225 Move xmm1, [rbx+32]
	226 Call Board.AddCoin, rcx, xmm1, r8, r9, stack:0x0
	227 Move rdi, stack:0x60
	228 Move rsi, stack:0x58
	229 Move r14, stack:0x68
	230 ShiftStack 64
	231 Move rbx, stack:0x0
	232 ShiftStack 8
	233 Return 
	234 Move rcx, [rbx+24]
	235 Compare rcx, 0
	236 JumpIfEqual {241}
	237 Move stack:0x28, r14
	238 Move r9, 4
	239 Move stack:0x20, 2
	240 Goto {224}
	241 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
