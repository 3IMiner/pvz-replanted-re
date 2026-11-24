# System.Void UpdateSquash()

- 类：`Plant`
- 汇编行数：809

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,60h
	cmp byte ptr [184EEB649h],0
	mov rbx,rcx
	jne short 00000001806BD361h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C97080h]
	call 00000001804FEB70h
	lea rcx,[184C96740h]
	call 00000001804FEB70h
	lea rcx,[184C97158h]
	call 00000001804FEB70h
	lea rcx,[184C968F0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB649h],1
	cmp dword ptr [rbx+88h],0
	mov [rsp+70h],rbp
	mov [rsp+78h],rsi
	mov [rsp+80h],rdi
	mov [rsp+88h],r12
	mov [rsp+58h],r14
	mov [rsp+50h],r15
	movaps [rsp+40h],xmm6
	je near ptr 00000001806BD921h
	cmp dword ptr [rbx+88h],3
	je near ptr 00000001806BD852h
	cmp dword ptr [rbx+88h],4
	je near ptr 00000001806BD7E0h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BDA72h
	movd xmm1,dword ptr [rbx+0CCh]
	xor r9d,r9d
	movss xmm2,dword ptr [rbx+24h]
	cvtdq2ps xmm1,xmm1
	call 000000018066BD30h
	mov rcx,[rbx+18h]
	mov ebp,eax
	mov r12d,[rbx+0CCh]
	test rcx,rcx
	je near ptr 00000001806BDA72h
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov edx,eax
	call 000000018065F630h
	cmp dword ptr [rbx+88h],5
	lea esi,[rax+8]
	je near ptr 00000001806BD66Dh
	cmp dword ptr [rbx+88h],6
	je short 00000001806BD45Eh
	cmp dword ptr [rbx+88h],7
	jne short 00000001806BD42Fh
	cmp dword ptr [rbx+0A0h],0
	jne short 00000001806BD42Fh
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	movaps xmm6,[rsp+40h]
	mov r15,[rsp+50h]
	mov r14,[rsp+58h]
	mov r12,[rsp+88h]
	mov rdi,[rsp+80h]
	mov rsi,[rsp+78h]
	mov rbp,[rsp+70h]
	add rsp,60h
	pop rbx
	ret
	mov rcx,[184C2AFC0h]
	mov r14d,[rbx+0A0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806BD47Ah
	call 00000001804FEEB0h
	xor edi,edi
	lea r9d,[rsi-78h]
	mov [rsp+30h],rdi
	mov r8d,r14d
	mov dword ptr [rsp+28h],1
	xor edx,edx
	mov ecx,0Ah
	mov [rsp+20h],esi
	call 00000001806CC120h
	cmp dword ptr [rbx+0A0h],5
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	movss dword ptr [rbx+24h],xmm0
	jne short 00000001806BD4BFh
	xor edx,edx
	mov rcx,rbx
	call 00000001806AE200h
	cmp [rbx+0A0h],edi
	jne near ptr 00000001806BD42Fh
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BDA72h
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov edx,ebp
	call 0000000180662110h
	test al,al
	jne near ptr 00000001806BD5C6h
	mov rcx,[rbx+18h]
	mov dword ptr [rbx+88h],7
	mov dword ptr [rbx+0A0h],64h
	test rcx,rcx
	je near ptr 00000001806BDA72h
	movss xmm3,dword ptr [183C33C4Ch]
	mov edx,1
	mov r8d,4
	mov [rsp+20h],rdi
	call 00000001806709C0h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806BDA72h
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806BDA72h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,28h
	call 0000000180002040h
	mov rcx,[rbx+18h]
	movss xmm6,dword ptr [183C33DCCh]
	test rcx,rcx
	je near ptr 00000001806BDA72h
	xor edx,edx
	call 00000001806719C0h
	test al,al
	je short 00000001806BD585h
	movss xmm6,dword ptr [183C33FECh]
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BDA72h
	addss xmm6,dword ptr [rbx+24h]
	movss xmm1,dword ptr [rbx+20h]
	mov r9d,[rbx+38h]
	addss xmm1,dword ptr [183C33DC4h]
	add r9d,4
	mov [rsp+28h],rdi
	movaps xmm2,xmm6
	mov dword ptr [rsp+20h],61h
	call 00000001807D9B50h
	jmp near ptr 00000001806BD42Fh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BDA72h
	movss xmm2,dword ptr [rbx+24h]
	movss xmm1,dword ptr [rbx+20h]
	mov r9d,[rbx+38h]
	addss xmm2,dword ptr [183C33DCCh]
	addss xmm1,dword ptr [183C33DC4h]
	inc r9d
	mov [rsp+28h],rdi
	mov dword ptr [rsp+20h],1Ah
	call 00000001807D9B50h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806BDA72h
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806BDA72h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,1
	call 0000000180002040h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806BDA72h
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806BDA72h
	mov rdx,[184C75168h]
	mov ecx,19h
	mov r9d,0A1h
	call 0000000180002040h
	jmp near ptr 00000001806BD425h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BDA72h
	mov r8d,[rbx+0D4h]
	xor r9d,r9d
	mov edx,[rbx+74h]
	call 000000018065F590h
	mov rcx,[rbx+18h]
	mov r15d,eax
	test rcx,rcx
	je near ptr 00000001806BDA72h
	mov r8d,[rbx+0D4h]
	xor r9d,r9d
	mov edx,[rbx+74h]
	call 000000018065F630h
	mov rcx,[184C2AFC0h]
	mov ebp,eax
	mov r14d,[rbx+0A0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806BD6CCh
	call 00000001804FEEB0h
	xor edi,edi
	mov r9d,r15d
	mov [rsp+30h],rdi
	mov r8d,r14d
	mov dword ptr [rsp+28h],4
	mov edx,14h
	mov ecx,32h
	mov [rsp+20h],r12d
	call 00000001806CC120h
	mov r8d,[rbx+0A0h]
	mov r9d,ebp
	mov [rsp+30h],rdi
	mov edx,14h
	mov dword ptr [rsp+28h],4
	mov ecx,32h
	movd xmm0,eax
	lea eax,[rsi-78h]
	cvtdq2ps xmm0,xmm0
	mov [rsp+20h],eax
	movss dword ptr [rbx+20h],xmm0
	call 00000001806CC120h
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	movss dword ptr [rbx+24h],xmm0
	cmp [rbx+0A0h],edi
	jne near ptr 00000001806BD42Fh
	cmp [184EEB658h],dil
	mov rsi,[184C96740h]
	jne short 00000001806BD775h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rsi,rsi
	je near ptr 00000001806BDA72h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rsi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BDA72h
	movss xmm3,dword ptr [183C33C68h]
	xor r8d,r8d
	mov [rsp+28h],rdi
	mov rdx,rax
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov dword ptr [rbx+88h],6
	mov dword ptr [rbx+0A0h],0Ah
	jmp near ptr 00000001806BD42Fh
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806BD42Fh
	xor edx,edx
	mov rcx,rbx
	call 00000001806AF3D0h
	test rax,rax
	je short 00000001806BD823h
	movss xmm1,dword ptr [183C33C60h]
	xor r8d,r8d
	mov rcx,rax
	call 000000018070A110h
	mov eax,[rbx+28h]
	cdq
	sub eax,edx
	cvttss2si ecx,xmm0
	sar eax,1
	sub ecx,eax
	mov [rbx+0CCh],ecx
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov dword ptr [rbx+88h],5
	mov ecx,4A768h
	mov dword ptr [rbx+0A0h],32h
	call 0000000180665070h
	mov [rbx+38h],eax
	jmp near ptr 00000001806BD42Fh
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806BD42Fh
	cmp byte ptr [184EEB658h],0
	mov rdi,[184C968F0h]
	jne short 00000001806BD88Eh
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806BDA72h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rsi,rax
	test rcx,rcx
	je near ptr 00000001806BDA72h
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BDA72h
	movss xmm3,dword ptr [183C33EF0h]
	xor edi,edi
	mov [rsp+28h],rdi
	xor r8d,r8d
	mov rdx,rsi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov dword ptr [rbx+88h],4
	mov dword ptr [rbx+0A0h],2Dh
	jmp near ptr 00000001806BD42Fh
	xor edx,edx
	mov rcx,rbx
	call 00000001806AF3D0h
	mov rdi,rax
	test rax,rax
	je near ptr 00000001806BD42Fh
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BDA72h
	xor r8d,r8d
	mov rdx,rax
	call 0000000180676EB0h
	xor r8d,r8d
	mov [rbx+120h],eax
	xorps xmm1,xmm1
	mov rcx,rdi
	call 000000018070A110h
	mov eax,[rbx+28h]
	cvttss2si ecx,xmm0
	cdq
	mov dword ptr [rbx+88h],3
	sub eax,edx
	mov dword ptr [rbx+0A0h],50h
	sar eax,1
	movss xmm0,dword ptr [rbx+20h]
	sub ecx,eax
	mov [rbx+0CCh],ecx
	mov rdi,[184C97158h]
	movd xmm1,ecx
	cvtdq2ps xmm1,xmm1
	comiss xmm0,xmm1
	jbe short 00000001806BD9AAh
	mov rdi,[184C97080h]
	cmp byte ptr [184EEB658h],0
	jne short 00000001806BD9D2h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806BDA72h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rsi,rax
	test rcx,rcx
	je short 00000001806BDA72h
	movss xmm1,dword ptr [183C33DACh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806BDA72h
	movss xmm3,dword ptr [183C33EF0h]
	xor edi,edi
	mov [rsp+28h],rdi
	xor r8d,r8d
	mov rdx,rsi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov r8,[rbx+10h]
	test r8,r8
	je short 00000001806BDA72h
	mov r8,[r8+58h]
	test r8,r8
	je short 00000001806BDA72h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,29h
	call 0000000180002040h
	jmp near ptr 00000001806BD42Fh
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -96
	004 Compare [0x184EEB649], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {20}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C75168]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C97080]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C96740]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184C97158]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C968F0]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 Move [0x184EEB649], 1
	020 Compare [rbx+136], 0
	021 Move stack:0x70, rbp
	022 Move stack:0x78, rsi
	023 Move stack:0x80, rdi
	024 Move stack:0x88, r12
	025 Move stack:0x58, r14
	026 Move stack:0x50, r15
	027 Move stack:0x40, xmm6
	028 JumpIfEqual {327}
	029 Compare [rbx+136], 3
	030 JumpIfEqual {289}
	031 Compare [rbx+136], 4
	032 JumpIfEqual {255}
	033 Move rcx, [rbx+24]
	034 Compare rcx, 0
	035 JumpIfEqual {410}
	036 Move xmm1, [rbx+204]
	037 Move r9, 0
	038 Move xmm2, [rbx+36]
	039 Move xmm1, xmm1
	040 Call Board.PixelToGridXKeepOnBoard, rcx, xmm1, r8
	041 Move rcx, [rbx+24]
	042 Move rbp, rax
	043 Move r12, [rbx+204]
	044 Compare rcx, 0
	045 JumpIfEqual {410}
	046 Move r8, [rbx+52]
	047 Move r9, 0
	048 Move rdx, rax
	049 Call Board.GridToPixelY, rcx, rdx, r8
	050 Compare [rbx+136], 5
	051 LoadAddress rsi, [rax+8]
	052 JumpIfEqual {181}
	053 Compare [rbx+136], 6
	054 JumpIfEqual {73}
	055 Compare [rbx+136], 7
	056 JumpIfNotEqual {62}
	057 Compare [rbx+160], 0
	058 JumpIfNotEqual {62}
	059 Move rdx, 0
	060 Move rcx, rbx
	061 Call Plant.Die, rcx, rdx
	062 Move xmm6, stack:0x40
	063 Move r15, stack:0x50
	064 Move r14, stack:0x58
	065 Move r12, stack:0x88
	066 Move rdi, stack:0x80
	067 Move rsi, stack:0x78
	068 Move rbp, stack:0x70
	069 ShiftStack 96
	070 Move rbx, stack:0x0
	071 ShiftStack 8
	072 Return 
	073 Move rcx, typeof(Reloaded.Gameplay.Common)
	074 Move r14, [rbx+160]
	075 Compare [rcx+228], 0
	076 JumpIfNotEqual {78}
	077 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	078 Move rdi, 0
	079 LoadAddress r9, [rsi-120]
	080 Move stack:0x30, rdi
	081 Move r8, r14
	082 Move stack:0x28, 1
	083 Move rdx, 0
	084 Move rcx, 10
	085 Move stack:0x20, rsi
	086 Call Common.TodAnimateCurve, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	087 Compare [rbx+160], 5
	088 Move xmm0, rax
	089 Move xmm0, xmm0
	090 Move [rbx+36], xmm0
	091 JumpIfNotEqual {95}
	092 Move rdx, 0
	093 Move rcx, rbx
	094 Call Plant.DoSquashDamage, rcx, rdx
	095 Compare [rbx+160], rdi
	096 JumpIfNotEqual {62}
	097 Move rcx, [rbx+24]
	098 Compare rcx, 0
	099 JumpIfEqual {410}
	100 Move r8, [rbx+52]
	101 Move r9, 0
	102 Move rdx, rbp
	103 Call Board.IsPoolSquare, rcx, rdx, r8
	104 Compare rax, 0
	105 JumpIfNotEqual {148}
	106 Move rcx, [rbx+24]
	107 Move [rbx+136], 7
	108 Move [rbx+160], 100
	109 Compare rcx, 0
	110 JumpIfEqual {410}
	111 Move xmm3, [0x183C33C4C]
	112 Move rdx, 1
	113 Move r8, 4
	114 Move stack:0x20, rdi
	115 Call Board.ShakeBoard, rcx, rdx, xmm2, r9
	116 Move r8, [rbx+16]
	117 Compare r8, 0
	118 JumpIfEqual {410}
	119 Move r8, [r8+88]
	120 Compare r8, 0
	121 JumpIfEqual {410}
	122 Move rdx, typeof(Reloaded.Services.IAudioService)
	123 Move rcx, 6
	124 Move r9, 40
	125 Call 0x180002040, rcx, rdx, r8, r9
	126 Move rcx, [rbx+24]
	127 Move xmm6, [0x183C33DCC]
	128 Compare rcx, 0
	129 JumpIfEqual {410}
	130 Move rdx, 0
	131 Call Board.StageHasRoof, rcx, rdx
	132 Compare rax, 0
	133 JumpIfEqual {135}
	134 Move xmm6, [0x183C33FEC]
	135 Move rcx, [rbx+16]
	136 Compare rcx, 0
	137 JumpIfEqual {410}
	138 Add xmm6, xmm6, [rbx+36]
	139 Move xmm1, [rbx+32]
	140 Move r9, [rbx+56]
	141 Add xmm1, xmm1, [0x183C33DC4]
	142 Add r9, r9, 4
	143 Move stack:0x28, rdi
	144 Move xmm2, xmm6
	145 Move stack:0x20, 97
	146 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	147 Goto {62}
	148 Move rcx, [rbx+16]
	149 Compare rcx, 0
	150 JumpIfEqual {410}
	151 Move xmm2, [rbx+36]
	152 Move xmm1, [rbx+32]
	153 Move r9, [rbx+56]
	154 Add xmm2, xmm2, [0x183C33DCC]
	155 Add xmm1, xmm1, [0x183C33DC4]
	156 Add r9, r9, 1
	157 Move stack:0x28, rdi
	158 Move stack:0x20, 26
	159 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	160 Move r8, [rbx+16]
	161 Compare r8, 0
	162 JumpIfEqual {410}
	163 Move r8, [r8+88]
	164 Compare r8, 0
	165 JumpIfEqual {410}
	166 Move rdx, typeof(Reloaded.Services.IAudioService)
	167 Move rcx, 6
	168 Move r9, 1
	169 Call 0x180002040, rcx, rdx, r8, r9
	170 Move r8, [rbx+16]
	171 Compare r8, 0
	172 JumpIfEqual {410}
	173 Move r8, [r8+88]
	174 Compare r8, 0
	175 JumpIfEqual {410}
	176 Move rdx, typeof(Reloaded.Services.IAudioService)
	177 Move rcx, 25
	178 Move r9, 161
	179 Call 0x180002040, rcx, rdx, r8, r9
	180 Goto {59}
	181 Move rcx, [rbx+24]
	182 Compare rcx, 0
	183 JumpIfEqual {410}
	184 Move r8, [rbx+212]
	185 Move r9, 0
	186 Move rdx, [rbx+116]
	187 Call Board.GridToPixelX, rcx, rdx, r8
	188 Move rcx, [rbx+24]
	189 Move r15, rax
	190 Compare rcx, 0
	191 JumpIfEqual {410}
	192 Move r8, [rbx+212]
	193 Move r9, 0
	194 Move rdx, [rbx+116]
	195 Call Board.GridToPixelY, rcx, rdx, r8
	196 Move rcx, typeof(Reloaded.Gameplay.Common)
	197 Move rbp, rax
	198 Move r14, [rbx+160]
	199 Compare [rcx+228], 0
	200 JumpIfNotEqual {202}
	201 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	202 Move rdi, 0
	203 Move r9, r15
	204 Move stack:0x30, rdi
	205 Move r8, r14
	206 Move stack:0x28, 4
	207 Move rdx, 20
	208 Move rcx, 50
	209 Move stack:0x20, r12
	210 Call Common.TodAnimateCurve, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	211 Move r8, [rbx+160]
	212 Move r9, rbp
	213 Move stack:0x30, rdi
	214 Move rdx, 20
	215 Move stack:0x28, 4
	216 Move rcx, 50
	217 Move xmm0, rax
	218 LoadAddress rax, [rsi-120]
	219 Move xmm0, xmm0
	220 Move stack:0x20, rax
	221 Move [rbx+32], xmm0
	222 Call Common.TodAnimateCurve, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	223 Move xmm0, rax
	224 Move xmm0, xmm0
	225 Move [rbx+36], xmm0
	226 Compare [rbx+160], rdi
	227 JumpIfNotEqual {62}
	228 Compare [0x184EEB658], rdi
	229 Move rsi, "anim_jumpdown"
	230 JumpIfNotEqual {236}
	231 LoadAddress rcx, [0x184C92A80]
	232 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	233 LoadAddress rcx, [0x184C911F8]
	234 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	235 Move [0x184EEB658], 1
	236 Compare rsi, 0
	237 JumpIfEqual {410}
	238 Move r8, ""
	239 Move r9, 0
	240 Move rdx, "anim_"
	241 Move rcx, rsi
	242 Call String.Replace, rcx, rdx, r8
	243 Move rcx, [rbx+320]
	244 Compare rcx, 0
	245 JumpIfEqual {410}
	246 Move xmm3, [0x183C33C68]
	247 Move r8, 0
	248 Move stack:0x28, rdi
	249 Move rdx, rax
	250 Move stack:0x20, 3
	251 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	252 Move [rbx+136], 6
	253 Move [rbx+160], 10
	254 Goto {62}
	255 Compare [rbx+160], 0
	256 JumpIfNotEqual {62}
	257 Move rdx, 0
	258 Move rcx, rbx
	259 Call Plant.FindSquashTarget, rcx, rdx
	260 Compare rax, 0
	261 JumpIfEqual {280}
	262 Move xmm1, [0x183C33C60]
	263 Move r8, 0
	264 Move rcx, rax
	265 Call Zombie.ZombieTargetLeadX, rcx, rdx
	266 Move rax, [rbx+40]
	267 Move TEMP, rax
	268 ShiftRight TEMP, 31
	269 Compare TEMP, 1
	270 JumpIfNotEqual {273}
	271 Move rdx, 0xFFFFFFFF
	272 Goto {274}
	273 Move rdx, 0
	274 Nop 
	275 Subtract rax, rax, rdx
	276 NotImplemented "cvttss2si ecx,xmm0"
	277 ShiftRight rax, 1
	278 Subtract rcx, rcx, rax
	279 Move [rbx+204], rcx
	280 Move rdx, [rbx+52]
	281 Move r9, 0
	282 Move r8, 0
	283 Move [rbx+136], 5
	284 Move rcx, 0x4A768
	285 Move [rbx+160], 50
	286 Call Board.MakeRenderOrder, rcx, rdx, r8, r9
	287 Move [rbx+56], rax
	288 Goto {62}
	289 Compare [rbx+160], 0
	290 JumpIfNotEqual {62}
	291 Compare [0x184EEB658], 0
	292 Move rdi, "anim_jumpup"
	293 JumpIfNotEqual {299}
	294 LoadAddress rcx, [0x184C92A80]
	295 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	296 LoadAddress rcx, [0x184C911F8]
	297 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	298 Move [0x184EEB658], 1
	299 Compare rdi, 0
	300 JumpIfEqual {410}
	301 Move r8, ""
	302 Move r9, 0
	303 Move rdx, "anim_"
	304 Move rcx, rdi
	305 Call String.Replace, rcx, rdx, r8
	306 Move rcx, [rbx+320]
	307 Move rsi, rax
	308 Compare rcx, 0
	309 JumpIfEqual {410}
	310 Move xmm1, [0x183C33DBC]
	311 Move r9, 0
	312 Move r8, 0
	313 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	314 Move rcx, [rbx+320]
	315 Compare rcx, 0
	316 JumpIfEqual {410}
	317 Move xmm3, [0x183C33EF0]
	318 Move rdi, 0
	319 Move stack:0x28, rdi
	320 Move r8, 0
	321 Move rdx, rsi
	322 Move stack:0x20, 3
	323 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	324 Move [rbx+136], 4
	325 Move [rbx+160], 45
	326 Goto {62}
	327 Move rdx, 0
	328 Move rcx, rbx
	329 Call Plant.FindSquashTarget, rcx, rdx
	330 Move rdi, rax
	331 Compare rax, 0
	332 JumpIfEqual {62}
	333 Move rcx, [rbx+24]
	334 Compare rcx, 0
	335 JumpIfEqual {410}
	336 Move r8, 0
	337 Move rdx, rax
	338 Call Board.ZombieGetID, rcx, rdx
	339 Move r8, 0
	340 Move [rbx+288], rax
	341 Move xmm1, 0
	342 Move rcx, rdi
	343 Call Zombie.ZombieTargetLeadX, rcx, rdx
	344 Move rax, [rbx+40]
	345 NotImplemented "cvttss2si ecx,xmm0"
	346 Move TEMP, rax
	347 ShiftRight TEMP, 31
	348 Compare TEMP, 1
	349 JumpIfNotEqual {352}
	350 Move rdx, 0xFFFFFFFF
	351 Goto {353}
	352 Move rdx, 0
	353 Nop 
	354 Move [rbx+136], 3
	355 Subtract rax, rax, rdx
	356 Move [rbx+160], 80
	357 ShiftRight rax, 1
	358 Move xmm0, [rbx+32]
	359 Subtract rcx, rcx, rax
	360 Move [rbx+204], rcx
	361 Move rdi, "anim_lookright"
	362 Move xmm1, rcx
	363 Move xmm1, xmm1
	364 Compare xmm0, xmm1
	365 JumpIfLessOrEqual {367}
	366 Move rdi, "anim_lookleft"
	367 Compare [0x184EEB658], 0
	368 JumpIfNotEqual {374}
	369 LoadAddress rcx, [0x184C92A80]
	370 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	371 LoadAddress rcx, [0x184C911F8]
	372 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	373 Move [0x184EEB658], 1
	374 Compare rdi, 0
	375 JumpIfEqual {410}
	376 Move r8, ""
	377 Move r9, 0
	378 Move rdx, "anim_"
	379 Move rcx, rdi
	380 Call String.Replace, rcx, rdx, r8
	381 Move rcx, [rbx+320]
	382 Move rsi, rax
	383 Compare rcx, 0
	384 JumpIfEqual {410}
	385 Move xmm1, [0x183C33DAC]
	386 Move r9, 0
	387 Move r8, 0
	388 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	389 Move rcx, [rbx+320]
	390 Compare rcx, 0
	391 JumpIfEqual {410}
	392 Move xmm3, [0x183C33EF0]
	393 Move rdi, 0
	394 Move stack:0x28, rdi
	395 Move r8, 0
	396 Move rdx, rsi
	397 Move stack:0x20, 3
	398 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	399 Move r8, [rbx+16]
	400 Compare r8, 0
	401 JumpIfEqual {410}
	402 Move r8, [r8+88]
	403 Compare r8, 0
	404 JumpIfEqual {410}
	405 Move rdx, typeof(Reloaded.Services.IAudioService)
	406 Move rcx, 6
	407 Move r9, 41
	408 Call 0x180002040, rcx, rdx, r8, r9
	409 Goto {62}
	410 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
