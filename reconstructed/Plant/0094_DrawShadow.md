# System.Void DrawShadow(System.Single theOffsetX, System.Single theOffsetY)

- 类：`Plant`
- 汇编行数：601

## 反汇编

```asm

Disassembly:
	mov [rsp+10h],rbx
	push rsi
	sub rsp,70h
	cmp byte ptr [184EEB661h],0
	mov rbx,rcx
	movaps [rsp+40h],xmm8
	movaps xmm8,xmm2
	movaps [rsp+30h],xmm9
	movaps xmm9,xmm1
	jne short 00000001806AE87Dh
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB661h],1
	imul eax,[rbx+34h],2710h
	xor esi,esi
	mov [rbx+5Ch],esi
	mov dword ptr [rbx+60h],0FFFFFFFFh
	add eax,30D43h
	cmp dword ptr [rbx+70h],10h
	mov [rbx+58h],eax
	je near ptr 00000001806AEDB3h
	cmp dword ptr [rbx+70h],1Dh
	je near ptr 00000001806AEDB3h
	cmp dword ptr [rbx+70h],13h
	je near ptr 00000001806AEDB3h
	cmp dword ptr [rbx+70h],18h
	je near ptr 00000001806AEDB3h
	cmp dword ptr [rbx+70h],2Fh
	je near ptr 00000001806AEDB3h
	cmp dword ptr [rbx+70h],15h
	je near ptr 00000001806AEDB3h
	cmp dword ptr [rbx+70h],2Eh
	je near ptr 00000001806AEDB3h
	cmp dword ptr [rbx+70h],0Bh
	je near ptr 00000001806AEDB3h
	cmp dword ptr [rbx+70h],2Bh
	je near ptr 00000001806AEDB3h
	cmp dword ptr [rbx+128h],2
	je near ptr 00000001806AEDB3h
	mov [rsp+80h],rdi
	movaps [rsp+60h],xmm6
	movaps [rsp+50h],xmm7
	cmp [rbx+18h],rsi
	je short 00000001806AE95Fh
	cmp [rbx+137h],sil
	je short 00000001806AE95Fh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AEDCDh
	xor edx,edx
	call 00000001807E3010h
	cmp eax,2Bh
	jne short 00000001806AE95Fh
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806AEDCDh
	mov rcx,[rax+108h]
	test rcx,rcx
	je near ptr 00000001806AEDCDh
	cmp [rcx+20h],esi
	je near ptr 00000001806AEDA1h
	mov edi,esi
	movss xmm6,dword ptr [183C33C4Ch]
	movaps xmm7,xmm6
	mov dword ptr [rbx+48h],0C0400000h
	mov dword ptr [rbx+4Ch],424C0000h
	cmp [rbx+18h],rsi
	je short 00000001806AE995h
	mov rcx,[rbx+18h]
	xor edx,edx
	call 0000000180671AF0h
	test al,al
	mov ecx,1
	cmovne edi,ecx
	cmp dword ptr [rbx+70h],11h
	je near ptr 00000001806AEC75h
	cmp dword ptr [rbx+70h],8
	je near ptr 00000001806AEC5Eh
	cmp dword ptr [rbx+70h],18h
	je near ptr 00000001806AEC5Eh
	cmp dword ptr [rbx+70h],9
	je near ptr 00000001806AEBDCh
	cmp dword ptr [rbx+70h],25h
	je near ptr 00000001806AEBB4h
	cmp dword ptr [rbx+70h],0Ah
	je near ptr 00000001806AEB9Ah
	cmp dword ptr [rbx+70h],2Ah
	je near ptr 00000001806AEB9Ah
	cmp dword ptr [rbx+70h],20h
	je near ptr 00000001806AEBA2h
	cmp dword ptr [rbx+70h],27h
	je near ptr 00000001806AEBA2h
	cmp dword ptr [rbx+70h],2Ch
	je near ptr 00000001806AEBA2h
	cmp dword ptr [rbx+70h],22h
	je near ptr 00000001806AEB71h
	cmp dword ptr [rbx+70h],0Dh
	je near ptr 00000001806AEB48h
	cmp dword ptr [rbx+70h],6
	je near ptr 00000001806AEB1Fh
	cmp dword ptr [rbx+70h],21h
	je near ptr 00000001806AEAFAh
	cmp dword ptr [rbx+70h],17h
	je near ptr 00000001806AEAE0h
	cmp dword ptr [rbx+70h],1Eh
	je near ptr 00000001806AEAC6h
	cmp dword ptr [rbx+70h],1Ah
	je short 00000001806AEAA6h
	cmp dword ptr [rbx+70h],19h
	je short 00000001806AEA94h
	cmp dword ptr [rbx+70h],23h
	je short 00000001806AEA82h
	cmp dword ptr [rbx+70h],32h
	jne near ptr 00000001806AECBAh
	movss xmm0,dword ptr [rbx+48h]
	movss xmm1,dword ptr [rbx+4Ch]
	subss xmm0,dword ptr [183C33C60h]
	addss xmm1,dword ptr [183C33ED4h]
	movss xmm7,dword ptr [183C33ECCh]
	movss dword ptr [rbx+48h],xmm0
	movss dword ptr [rbx+4Ch],xmm1
	jmp near ptr 00000001806AECBAh
	movss xmm0,dword ptr [rbx+4Ch]
	addss xmm0,dword ptr [183C33DBCh]
	jmp near ptr 00000001806AECB5h
	movss xmm0,dword ptr [rbx+4Ch]
	addss xmm0,dword ptr [183C33DA0h]
	jmp near ptr 00000001806AECB5h
	movss xmm0,dword ptr [rbx+48h]
	subss xmm0,dword ptr [183C33ED4h]
	movss dword ptr [rbx+48h],xmm0
	movss xmm0,dword ptr [rbx+4Ch]
	subss xmm0,xmm6
	jmp near ptr 00000001806AECB5h
	movss xmm0,dword ptr [rbx+4Ch]
	subss xmm0,dword ptr [183C33ED4h]
	movss xmm7,dword ptr [183C33F9Ch]
	jmp near ptr 00000001806AECB5h
	movss xmm0,dword ptr [rbx+4Ch]
	addss xmm0,dword ptr [183C33D9Ch]
	movss xmm7,dword ptr [183C33D90h]
	jmp near ptr 00000001806AECB5h
	movss xmm0,dword ptr [rbx+48h]
	movss xmm1,dword ptr [rbx+4Ch]
	subss xmm0,xmm6
	subss xmm1,dword ptr [183C33ED4h]
	movss dword ptr [rbx+48h],xmm0
	movss dword ptr [rbx+4Ch],xmm1
	jmp near ptr 00000001806AECBAh
	movss xmm0,dword ptr [rbx+48h]
	movss xmm1,dword ptr [rbx+4Ch]
	subss xmm0,dword ptr [183C33EE4h]
	addss xmm1,dword ptr [183C33DA0h]
	movss dword ptr [rbx+48h],xmm0
	movss dword ptr [rbx+4Ch],xmm1
	jmp near ptr 00000001806AECBAh
	movss xmm0,dword ptr [rbx+48h]
	movss xmm1,dword ptr [rbx+4Ch]
	subss xmm0,dword ptr [183C33DA0h]
	addss xmm1,dword ptr [183C33C5Ch]
	movss dword ptr [rbx+48h],xmm0
	movss dword ptr [rbx+4Ch],xmm1
	jmp near ptr 00000001806AECBAh
	movss xmm0,dword ptr [rbx+48h]
	movss xmm1,dword ptr [rbx+4Ch]
	addss xmm0,dword ptr [183C33D9Ch]
	subss xmm1,dword ptr [183C33C5Ch]
	movss dword ptr [rbx+48h],xmm0
	movss dword ptr [rbx+4Ch],xmm1
	jmp near ptr 00000001806AECBAh
	movss xmm7,dword ptr [183C33D90h]
	movss xmm0,dword ptr [rbx+4Ch]
	subss xmm0,dword ptr [183C33C5Ch]
	jmp near ptr 00000001806AECB5h
	movss xmm0,dword ptr [rbx+48h]
	subss xmm0,dword ptr [183C33C5Ch]
	movss xmm7,dword ptr [183C33C40h]
	movss dword ptr [rbx+48h],xmm0
	movss xmm0,dword ptr [rbx+4Ch]
	addss xmm0,xmm6
	jmp near ptr 00000001806AECB5h
	cmp dword ptr [rbx+88h],17h
	movss xmm0,dword ptr [rbx+4Ch]
	subss xmm0,dword ptr [183C33DA8h]
	movss dword ptr [rbx+4Ch],xmm0
	je short 00000001806AEC54h
	cmp dword ptr [rbx+88h],18h
	je short 00000001806AEC08h
	movaps xmm7,xmm6
	jmp near ptr 00000001806AECBAh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AEDCDh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78E0h
	mov rcx,[184C2AFC0h]
	movaps xmm7,xmm0
	cmp [rcx+0E4h],esi
	jne short 00000001806AEC39h
	call 00000001804FEEB0h
	movss xmm0,dword ptr [183C33C40h]
	xor r9d,r9d
	movaps xmm2,xmm7
	movaps xmm1,xmm6
	call 00000001806CB8D0h
	movaps xmm7,xmm0
	jmp short 00000001806AECBAh
	movss xmm7,dword ptr [183C33C40h]
	jmp short 00000001806AECBAh
	movss xmm0,dword ptr [rbx+4Ch]
	subss xmm0,dword ptr [183C33DA8h]
	movss xmm7,dword ptr [183C33C40h]
	jmp short 00000001806AECB5h
	cmp [rbx+18h],rsi
	je short 00000001806AECA8h
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov edx,[rbx+74h]
	mov rcx,[rbx+18h]
	movss xmm6,dword ptr [rbx+4Ch]
	call 000000018065F630h
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	subss xmm0,dword ptr [rbx+24h]
	addss xmm0,xmm6
	movss dword ptr [rbx+4Ch],xmm0
	movss xmm0,dword ptr [rbx+4Ch]
	addss xmm0,dword ptr [183C33ED4h]
	movss dword ptr [rbx+4Ch],xmm0
	cmp dword ptr [rbx+70h],23h
	jne short 00000001806AED29h
	movss xmm0,dword ptr [rbx+4Ch]
	addss xmm0,dword ptr [183C33DACh]
	movss dword ptr [rbx+4Ch],xmm0
	cmp [rbx+18h],rsi
	je near ptr 00000001806AED76h
	mov r8d,[rbx+34h]
	mov r9d,6
	mov edx,[rbx+74h]
	mov rcx,[rbx+18h]
	mov [rsp+20h],rsi
	call 000000018065F2A0h
	test rax,rax
	jne near ptr 00000001806AEDA1h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AEDCDh
	mov r8d,[rbx+34h]
	mov r9d,8
	mov edx,[rbx+74h]
	mov [rsp+20h],rsi
	call 000000018065F2A0h
	test rax,rax
	jne short 00000001806AEDA1h
	cmp [rbx+18h],rsi
	je short 00000001806AED76h
	mov rcx,[rbx+18h]
	xor edx,edx
	call 0000000180671820h
	test al,al
	je short 00000001806AED76h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AEDCDh
	mov r8d,[rbx+34h]
	mov r9d,9
	mov edx,[rbx+74h]
	mov [rsp+20h],rsi
	call 000000018065F2A0h
	test rax,rax
	je short 00000001806AED76h
	cmp dword ptr [rax+70h],10h
	jne short 00000001806AED76h
	mov eax,[rax+38h]
	sub eax,0Fh
	mov [rbx+58h],eax
	lea eax,[rdi+1]
	mov [rbx+5Ch],eax
	mov [rbx+60h],esi
	addss xmm9,dword ptr [rbx+48h]
	addss xmm8,dword ptr [rbx+4Ch]
	movss dword ptr [rbx+50h],xmm7
	movss dword ptr [rbx+54h],xmm7
	movss dword ptr [rbx+48h],xmm9
	movss dword ptr [rbx+4Ch],xmm8
	movaps xmm6,[rsp+60h]
	mov rdi,[rsp+80h]
	movaps xmm7,[rsp+50h]
	mov rbx,[rsp+88h]
	movaps xmm8,[rsp+40h]
	movaps xmm9,[rsp+30h]
	add rsp,70h
	pop rsi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x10, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rsi
	004 ShiftStack -112
	005 Compare [0x184EEB661], 0
	006 Move rbx, rcx
	007 Move stack:0x40, xmm8
	008 Move xmm8, xmm2
	009 Move stack:0x30, xmm9
	010 Move xmm9, xmm1
	011 JumpIfNotEqual {15}
	012 LoadAddress rcx, [0x184C2AFC0]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 Move [0x184EEB661], 1
	015 Multiply rax, [rbx+52], 0x2710
	016 Move rsi, 0
	017 Move [rbx+92], rsi
	018 Move [rbx+96], 0xFFFFFFFF
	019 Add rax, rax, 0x30D43
	020 Compare [rbx+112], 16
	021 Move [rbx+88], rax
	022 JumpIfEqual {293}
	023 Compare [rbx+112], 29
	024 JumpIfEqual {293}
	025 Compare [rbx+112], 19
	026 JumpIfEqual {293}
	027 Compare [rbx+112], 24
	028 JumpIfEqual {293}
	029 Compare [rbx+112], 47
	030 JumpIfEqual {293}
	031 Compare [rbx+112], 21
	032 JumpIfEqual {293}
	033 Compare [rbx+112], 46
	034 JumpIfEqual {293}
	035 Compare [rbx+112], 11
	036 JumpIfEqual {293}
	037 Compare [rbx+112], 43
	038 JumpIfEqual {293}
	039 Compare [rbx+296], 2
	040 JumpIfEqual {293}
	041 Move stack:0x80, rdi
	042 Move stack:0x60, xmm6
	043 Move stack:0x50, xmm7
	044 Compare [rbx+24], rsi
	045 JumpIfEqual {63}
	046 Compare [rbx+311], rsi
	047 JumpIfEqual {63}
	048 Move rcx, [rbx+16]
	049 Compare rcx, 0
	050 JumpIfEqual {300}
	051 Move rdx, 0
	052 Call GameplayActivity.get_GameMode, rcx, rdx
	053 Compare rax, 43
	054 JumpIfNotEqual {63}
	055 Move rax, [rbx+16]
	056 Compare rax, 0
	057 JumpIfEqual {300}
	058 Move rcx, [rax+264]
	059 Compare rcx, 0
	060 JumpIfEqual {300}
	061 Compare [rcx+32], rsi
	062 JumpIfEqual {290}
	063 Move rdi, rsi
	064 Move xmm6, [0x183C33C4C]
	065 Move xmm7, xmm6
	066 Move [rbx+72], 0xC0400000
	067 Move [rbx+76], 0x424C0000
	068 Compare [rbx+24], rsi
	069 JumpIfEqual {78}
	070 Move rcx, [rbx+24]
	071 Move rdx, 0
	072 Call Board.StageIsNight, rcx, rdx
	073 Compare rax, 0
	074 Move rcx, 1
	075 JumpIfEqual {77}
	076 Move rdi, rcx
	077 Nop 
	078 Compare [rbx+112], 17
	079 JumpIfEqual {218}
	080 Compare [rbx+112], 8
	081 JumpIfEqual {214}
	082 Compare [rbx+112], 24
	083 JumpIfEqual {214}
	084 Compare [rbx+112], 9
	085 JumpIfEqual {185}
	086 Compare [rbx+112], 37
	087 JumpIfEqual {178}
	088 Compare [rbx+112], 10
	089 JumpIfEqual {174}
	090 Compare [rbx+112], 42
	091 JumpIfEqual {174}
	092 Compare [rbx+112], 32
	093 JumpIfEqual {175}
	094 Compare [rbx+112], 39
	095 JumpIfEqual {175}
	096 Compare [rbx+112], 44
	097 JumpIfEqual {175}
	098 Compare [rbx+112], 34
	099 JumpIfEqual {167}
	100 Compare [rbx+112], 13
	101 JumpIfEqual {160}
	102 Compare [rbx+112], 6
	103 JumpIfEqual {153}
	104 Compare [rbx+112], 33
	105 JumpIfEqual {146}
	106 Compare [rbx+112], 23
	107 JumpIfEqual {142}
	108 Compare [rbx+112], 30
	109 JumpIfEqual {138}
	110 Compare [rbx+112], 26
	111 JumpIfEqual {132}
	112 Compare [rbx+112], 25
	113 JumpIfEqual {129}
	114 Compare [rbx+112], 35
	115 JumpIfEqual {126}
	116 Compare [rbx+112], 50
	117 JumpIfNotEqual {234}
	118 Move xmm0, [rbx+72]
	119 Move xmm1, [rbx+76]
	120 Subtract xmm0, xmm0, [0x183C33C60]
	121 Add xmm1, xmm1, [0x183C33ED4]
	122 Move xmm7, [0x183C33ECC]
	123 Move [rbx+72], xmm0
	124 Move [rbx+76], xmm1
	125 Goto {234}
	126 Move xmm0, [rbx+76]
	127 Add xmm0, xmm0, [0x183C33DBC]
	128 Goto {233}
	129 Move xmm0, [rbx+76]
	130 Add xmm0, xmm0, [0x183C33DA0]
	131 Goto {233}
	132 Move xmm0, [rbx+72]
	133 Subtract xmm0, xmm0, [0x183C33ED4]
	134 Move [rbx+72], xmm0
	135 Move xmm0, [rbx+76]
	136 Subtract xmm0, xmm0, xmm6
	137 Goto {233}
	138 Move xmm0, [rbx+76]
	139 Subtract xmm0, xmm0, [0x183C33ED4]
	140 Move xmm7, [0x183C33F9C]
	141 Goto {233}
	142 Move xmm0, [rbx+76]
	143 Add xmm0, xmm0, [0x183C33D9C]
	144 Move xmm7, [0x183C33D90]
	145 Goto {233}
	146 Move xmm0, [rbx+72]
	147 Move xmm1, [rbx+76]
	148 Subtract xmm0, xmm0, xmm6
	149 Subtract xmm1, xmm1, [0x183C33ED4]
	150 Move [rbx+72], xmm0
	151 Move [rbx+76], xmm1
	152 Goto {234}
	153 Move xmm0, [rbx+72]
	154 Move xmm1, [rbx+76]
	155 Subtract xmm0, xmm0, [0x183C33EE4]
	156 Add xmm1, xmm1, [0x183C33DA0]
	157 Move [rbx+72], xmm0
	158 Move [rbx+76], xmm1
	159 Goto {234}
	160 Move xmm0, [rbx+72]
	161 Move xmm1, [rbx+76]
	162 Subtract xmm0, xmm0, [0x183C33DA0]
	163 Add xmm1, xmm1, [0x183C33C5C]
	164 Move [rbx+72], xmm0
	165 Move [rbx+76], xmm1
	166 Goto {234}
	167 Move xmm0, [rbx+72]
	168 Move xmm1, [rbx+76]
	169 Add xmm0, xmm0, [0x183C33D9C]
	170 Subtract xmm1, xmm1, [0x183C33C5C]
	171 Move [rbx+72], xmm0
	172 Move [rbx+76], xmm1
	173 Goto {234}
	174 Move xmm7, [0x183C33D90]
	175 Move xmm0, [rbx+76]
	176 Subtract xmm0, xmm0, [0x183C33C5C]
	177 Goto {233}
	178 Move xmm0, [rbx+72]
	179 Subtract xmm0, xmm0, [0x183C33C5C]
	180 Move xmm7, [0x183C33C40]
	181 Move [rbx+72], xmm0
	182 Move xmm0, [rbx+76]
	183 Add xmm0, xmm0, xmm6
	184 Goto {233}
	185 Compare [rbx+136], 23
	186 Move xmm0, [rbx+76]
	187 Subtract xmm0, xmm0, [0x183C33DA8]
	188 Move [rbx+76], xmm0
	189 JumpIfEqual {212}
	190 Compare [rbx+136], 24
	191 JumpIfEqual {194}
	192 Move xmm7, xmm6
	193 Goto {234}
	194 Move rcx, [rbx+320]
	195 Compare rcx, 0
	196 JumpIfEqual {300}
	197 Move r8, 0
	198 Move rdx, 0
	199 Call ReloadedCharacterController.GetAnimationTimeOnTrack, rcx, rdx
	200 Move rcx, typeof(Reloaded.Gameplay.Common)
	201 Move xmm7, xmm0
	202 Compare [rcx+228], rsi
	203 JumpIfNotEqual {205}
	204 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	205 Move xmm0, [0x183C33C40]
	206 Move r9, 0
	207 Move xmm2, xmm7
	208 Move xmm1, xmm6
	209 Call 0x1806CB8D0, xmm0, xmm1, xmm2, r9
	210 Move xmm7, xmm0
	211 Goto {234}
	212 Move xmm7, [0x183C33C40]
	213 Goto {234}
	214 Move xmm0, [rbx+76]
	215 Subtract xmm0, xmm0, [0x183C33DA8]
	216 Move xmm7, [0x183C33C40]
	217 Goto {233}
	218 Compare [rbx+24], rsi
	219 JumpIfEqual {231}
	220 Move r8, [rbx+52]
	221 Move r9, 0
	222 Move rdx, [rbx+116]
	223 Move rcx, [rbx+24]
	224 Move xmm6, [rbx+76]
	225 Call Board.GridToPixelY, rcx, rdx, r8
	226 Move xmm0, rax
	227 Move xmm0, xmm0
	228 Subtract xmm0, xmm0, [rbx+36]
	229 Add xmm0, xmm0, xmm6
	230 Move [rbx+76], xmm0
	231 Move xmm0, [rbx+76]
	232 Add xmm0, xmm0, [0x183C33ED4]
	233 Move [rbx+76], xmm0
	234 Compare [rbx+112], 35
	235 JumpIfNotEqual {259}
	236 Move xmm0, [rbx+76]
	237 Add xmm0, xmm0, [0x183C33DAC]
	238 Move [rbx+76], xmm0
	239 Compare [rbx+24], rsi
	240 JumpIfEqual {281}
	241 Move r8, [rbx+52]
	242 Move r9, 6
	243 Move rdx, [rbx+116]
	244 Move rcx, [rbx+24]
	245 Move stack:0x20, rsi
	246 Call Board.GetTopPlantAt, rcx, rdx, r8, r9
	247 Compare rax, 0
	248 JumpIfNotEqual {290}
	249 Move rcx, [rbx+24]
	250 Compare rcx, 0
	251 JumpIfEqual {300}
	252 Move r8, [rbx+52]
	253 Move r9, 8
	254 Move rdx, [rbx+116]
	255 Move stack:0x20, rsi
	256 Call Board.GetTopPlantAt, rcx, rdx, r8, r9
	257 Compare rax, 0
	258 JumpIfNotEqual {290}
	259 Compare [rbx+24], rsi
	260 JumpIfEqual {281}
	261 Move rcx, [rbx+24]
	262 Move rdx, 0
	263 Call 0x180671820, rcx, rdx
	264 Compare rax, 0
	265 JumpIfEqual {281}
	266 Move rcx, [rbx+24]
	267 Compare rcx, 0
	268 JumpIfEqual {300}
	269 Move r8, [rbx+52]
	270 Move r9, 9
	271 Move rdx, [rbx+116]
	272 Move stack:0x20, rsi
	273 Call Board.GetTopPlantAt, rcx, rdx, r8, r9
	274 Compare rax, 0
	275 JumpIfEqual {281}
	276 Compare [rax+112], 16
	277 JumpIfNotEqual {281}
	278 Move rax, [rax+56]
	279 Subtract rax, rax, 15
	280 Move [rbx+88], rax
	281 LoadAddress rax, [rdi+1]
	282 Move [rbx+92], rax
	283 Move [rbx+96], rsi
	284 Add xmm9, xmm9, [rbx+72]
	285 Add xmm8, xmm8, [rbx+76]
	286 Move [rbx+80], xmm7
	287 Move [rbx+84], xmm7
	288 Move [rbx+72], xmm9
	289 Move [rbx+76], xmm8
	290 Move xmm6, stack:0x60
	291 Move rdi, stack:0x80
	292 Move xmm7, stack:0x50
	293 Move rbx, stack:0x88
	294 Move xmm8, stack:0x40
	295 Move xmm9, stack:0x30
	296 ShiftStack 112
	297 Move rsi, stack:0x0
	298 ShiftStack 8
	299 Return 
	300 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
