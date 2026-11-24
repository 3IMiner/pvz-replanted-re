# System.Void UpdateBowling()

- 类：`Plant`
- 汇编行数：817

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,70h
	cmp byte ptr [184EEB667h],0
	mov rbx,rcx
	jne short 00000001806B7D8Dh
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C7ECA0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB667h],1
	mov rcx,[rbx+140h]
	mov [rsp+80h],rbp
	mov [rsp+88h],rsi
	mov [rsp+90h],rdi
	movaps [rsp+60h],xmm6
	movaps [rsp+50h],xmm7
	test rcx,rcx
	je near ptr 00000001806B8496h
	xor edx,edx
	call 00000001807C7CF0h
	test al,al
	je short 00000001806B7E0Dh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	xor edx,edx
	call 00000001807C7A00h
	movss xmm2,dword ptr [rbx+20h]
	cvttss2si eax,xmm0
	movd xmm1,eax
	cvtdq2ps xmm1,xmm1
	subss xmm2,xmm1
	comiss xmm2,dword ptr [183C33DE8h]
	movss dword ptr [rbx+20h],xmm2
	jbe short 00000001806B7E0Dh
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	cmp dword ptr [rbx+88h],1Ch
	movss xmm6,dword ptr [183C33D94h]
	je short 00000001806B7E32h
	cmp dword ptr [rbx+88h],1Dh
	jne short 00000001806B7E40h
	movss xmm0,dword ptr [rbx+24h]
	addss xmm0,xmm6
	jmp short 00000001806B7E3Bh
	movss xmm0,dword ptr [rbx+24h]
	subss xmm0,xmm6
	movss dword ptr [rbx+24h],xmm0
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	mov r8d,[rbx+34h]
	xor r9d,r9d
	xor edx,edx
	call 000000018065F630h
	movd xmm1,eax
	cvtdq2ps xmm1,xmm1
	subss xmm1,dword ptr [rbx+24h]
	comiss xmm1,xmm6
	ja near ptr 00000001806B830Dh
	movss xmm0,dword ptr [183C33F20h]
	comiss xmm0,xmm1
	ja near ptr 00000001806B830Dh
	mov esi,[rbx+88h]
	cmp esi,1Ch
	jne short 00000001806B7E99h
	cmp dword ptr [rbx+34h],0
	jne short 00000001806B7EA9h
	mov esi,1Dh
	jmp short 00000001806B7EA9h
	cmp esi,1Dh
	jne short 00000001806B7EA9h
	cmp dword ptr [rbx+34h],4
	jne short 00000001806B7EA9h
	mov esi,1Ch
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	mov rdi,rax
	test rax,rax
	je near ptr 00000001806B8465h
	movd xmm6,dword ptr [rbx+28h]
	movd xmm7,dword ptr [rbx+2Ch]
	mov rax,[rbx+10h]
	cvtdq2ps xmm6,xmm6
	cvtdq2ps xmm7,xmm7
	mulss xmm6,dword ptr [183C33C40h]
	mulss xmm7,dword ptr [183C33C40h]
	addss xmm6,dword ptr [rbx+20h]
	addss xmm7,dword ptr [rbx+24h]
	test rax,rax
	je near ptr 00000001806B8496h
	cmp dword ptr [rbx+70h],31h
	mov r8,[rax+58h]
	je near ptr 00000001806B8335h
	test r8,r8
	je near ptr 00000001806B8496h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,14h
	call 0000000180002040h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	movss xmm3,dword ptr [183C33C4Ch]
	xor ebp,ebp
	mov edx,1
	mov [rsp+20h],rbp
	mov r8d,0FFFFFFFEh
	call 00000001806709C0h
	cmp dword ptr [rbx+70h],32h
	je near ptr 00000001806B801Dh
	cmp dword ptr [rdi+130h],1
	jne short 00000001806B7F76h
	cmp [rbx+88h],ebp
	jne near ptr 00000001806B801Dh
	cmp [rdi+130h],ebp
	jne near ptr 00000001806B8008h
	cmp [rdi+11Ch],ebp
	je near ptr 00000001806B801Dh
	cmp dword ptr [rdi+11Ch],2
	je short 00000001806B7FC2h
	cmp dword ptr [rdi+11Ch],1
	jne short 00000001806B7FF3h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B8496h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B8496h
	mov r9d,3Ah
	jmp short 00000001806B7FE2h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B8496h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B8496h
	mov r9d,2Eh
	mov rdx,[184C75168h]
	mov ecx,6
	call 0000000180002040h
	xor r9d,r9d
	xor r8d,r8d
	mov edx,384h
	mov rcx,rdi
	call 00000001806F9200h
	jmp short 00000001806B8030h
	xor r9d,r9d
	xor r8d,r8d
	mov edx,190h
	mov rcx,rdi
	call 00000001806F97F0h
	jmp short 00000001806B8030h
	xor r9d,r9d
	xor r8d,r8d
	mov edx,708h
	mov rcx,rdi
	call 00000001806F8F60h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	xor edx,edx
	call 00000001807DF540h
	test al,al
	je short 00000001806B8062h
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806B8496h
	cmp dword ptr [rax+1B8h],0Ah
	jle near ptr 00000001806B829Ch
	cmp dword ptr [rbx+70h],3
	jne near ptr 00000001806B829Ch
	mov eax,[rbx+0A4h]
	inc eax
	mov [rbx+0A4h],eax
	cmp eax,2
	je near ptr 00000001806B8240h
	cmp eax,3
	je near ptr 00000001806B81C5h
	cmp eax,4
	je near ptr 00000001806B811Ch
	cmp eax,5
	jl near ptr 00000001806B829Ch
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B8496h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B8496h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,4
	call 0000000180002040h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	mov [rsp+28h],rbp
	mov r9d,2
	movaps xmm2,xmm7
	mov dword ptr [rsp+20h],3
	movaps xmm1,xmm6
	call 0000000180654EA0h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	xor r9d,r9d
	mov r8b,1
	mov edx,8
	call 000000018065F560h
	jmp near ptr 00000001806B829Ch
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B8496h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B8496h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,4
	call 0000000180002040h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	movaps xmm1,xmm6
	mov [rsp+28h],rbp
	subss xmm1,dword ptr [183C33DACh]
	mov r9d,1
	mov dword ptr [rsp+20h],3
	movaps xmm2,xmm7
	call 0000000180654EA0h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	mov [rsp+28h],rbp
	mov r9d,1
	movaps xmm2,xmm7
	mov dword ptr [rsp+20h],3
	movaps xmm1,xmm6
	call 0000000180654EA0h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	addss xmm6,dword ptr [183C33DACh]
	jmp near ptr 00000001806B827Eh
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B8496h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B8496h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,4
	call 0000000180002040h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	movaps xmm1,xmm6
	mov [rsp+28h],rbp
	subss xmm1,dword ptr [183C33ED4h]
	mov r9d,1
	mov dword ptr [rsp+20h],3
	movaps xmm2,xmm7
	call 0000000180654EA0h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	addss xmm6,dword ptr [183C33ED4h]
	jmp short 00000001806B827Eh
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B8496h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B8496h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,4
	call 0000000180002040h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	mov [rsp+28h],rbp
	mov r9d,1
	movaps xmm2,xmm7
	mov dword ptr [rsp+20h],3
	movaps xmm1,xmm6
	call 0000000180654EA0h
	cmp dword ptr [rbx+70h],32h
	je near ptr 00000001806B8465h
	cmp dword ptr [rbx+34h],4
	je short 00000001806B82F3h
	cmp dword ptr [rbx+88h],1Dh
	je short 00000001806B82F3h
	cmp [rbx+34h],ebp
	je near ptr 00000001806B8477h
	cmp dword ptr [rbx+88h],1Ch
	je near ptr 00000001806B8477h
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806B82DFh
	call 00000001804FEEB0h
	xor edx,edx
	mov ecx,2
	call 00000001806CBE80h
	test eax,eax
	je near ptr 00000001806B8477h
	dec dword ptr [rbx+34h]
	xor edx,edx
	mov rcx,rbx
	mov dword ptr [rbx+88h],1Ch
	call 00000001806AC2A0h
	mov [rbx+38h],eax
	movaps xmm7,[rsp+50h]
	movaps xmm6,[rsp+60h]
	mov rdi,[rsp+90h]
	mov rsi,[rsp+88h]
	mov rbp,[rsp+80h]
	add rsp,70h
	pop rbx
	ret
	test r8,r8
	je near ptr 00000001806B8496h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,37h
	call 0000000180002040h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806B8496h
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806B8496h
	mov rdx,[184C75168h]
	mov ecx,19h
	mov r9d,0Eh
	call 0000000180002040h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B8496h
	mov r8,[rax+78h]
	test r8,r8
	je near ptr 00000001806B8496h
	mov rdx,[184C7ECA0h]
	mov ecx,17h
	mov r9d,1
	call 0000000180002040h
	mov rdi,[rbx+18h]
	xor r8d,r8d
	xor edx,edx
	mov rcx,rbx
	call 00000001806B12F0h
	or eax,2
	test rdi,rdi
	je near ptr 00000001806B8496h
	mov edx,[rbx+34h]
	xor ebp,ebp
	mov [rsp+40h],rbp
	movaps xmm3,xmm7
	mov [rsp+38h],eax
	movaps xmm2,xmm6
	mov byte ptr [rsp+30h],1
	mov rcx,rdi
	mov dword ptr [rsp+28h],1
	mov dword ptr [rsp+20h],5Ah
	call 0000000180664F40h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B8496h
	mov [rsp+28h],rbp
	mov r9d,61A80h
	movaps xmm2,xmm7
	mov dword ptr [rsp+20h],4
	movaps xmm1,xmm6
	call 00000001807D9B50h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je short 00000001806B8496h
	movss xmm3,dword ptr [183C33C4Ch]
	mov edx,3
	mov r8d,0FFFFFFFCh
	mov [rsp+20h],rbp
	call 00000001806709C0h
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	jmp near ptr 00000001806B830Dh
	cmp esi,1Ch
	je near ptr 00000001806B82F3h
	cmp esi,1Dh
	jne near ptr 00000001806B830Dh
	xor edx,edx
	mov dword ptr [rbx+88h],1Dh
	mov rcx,rbx
	call 00000001806AC2A0h
	inc dword ptr [rbx+34h]
	mov [rbx+38h],eax
	jmp near ptr 00000001806B830Dh
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -112
	004 Compare [0x184EEB667], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {14}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C75168]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C7ECA0]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 Move [0x184EEB667], 1
	014 Move rcx, [rbx+320]
	015 Move stack:0x80, rbp
	016 Move stack:0x88, rsi
	017 Move stack:0x90, rdi
	018 Move stack:0x60, xmm6
	019 Move stack:0x50, xmm7
	020 Compare rcx, 0
	021 JumpIfEqual {407}
	022 Move rdx, 0
	023 Call ReloadedCharacterController.HasGroundTransform, rcx, rdx
	024 Compare rax, 0
	025 JumpIfEqual {42}
	026 Move rcx, [rbx+320]
	027 Compare rcx, 0
	028 JumpIfEqual {407}
	029 Move rdx, 0
	030 Call ReloadedCharacterController.GetGroundVelocity, rcx, rdx
	031 Move xmm2, [rbx+32]
	032 NotImplemented "cvttss2si eax,xmm0"
	033 Move xmm1, rax
	034 Move xmm1, xmm1
	035 Subtract xmm2, xmm2, xmm1
	036 Compare xmm2, [0x183C33DE8]
	037 Move [rbx+32], xmm2
	038 JumpIfLessOrEqual {42}
	039 Move rdx, 0
	040 Move rcx, rbx
	041 Call Plant.Die, rcx, rdx
	042 Compare [rbx+136], 28
	043 Move xmm6, typeof(T)
	044 JumpIfEqual {50}
	045 Compare [rbx+136], 29
	046 JumpIfNotEqual {53}
	047 Move xmm0, [rbx+36]
	048 Add xmm0, xmm0, xmm6
	049 Goto {52}
	050 Move xmm0, [rbx+36]
	051 Subtract xmm0, xmm0, xmm6
	052 Move [rbx+36], xmm0
	053 Move rcx, [rbx+24]
	054 Compare rcx, 0
	055 JumpIfEqual {407}
	056 Move r8, [rbx+52]
	057 Move r9, 0
	058 Move rdx, 0
	059 Call Board.GridToPixelY, rcx, rdx, r8
	060 Move xmm1, rax
	061 Move xmm1, xmm1
	062 Subtract xmm1, xmm1, [rbx+36]
	063 Compare xmm1, xmm6
	064 JumpIfGreater {321}
	065 Move xmm0, [0x183C33F20]
	066 Compare xmm0, xmm1
	067 JumpIfGreater {321}
	068 Move rsi, [rbx+136]
	069 Compare rsi, 28
	070 JumpIfNotEqual {75}
	071 Compare [rbx+52], 0
	072 JumpIfNotEqual {80}
	073 Move rsi, 29
	074 Goto {80}
	075 Compare rsi, 29
	076 JumpIfNotEqual {80}
	077 Compare [rbx+52], 4
	078 JumpIfNotEqual {80}
	079 Move rsi, 28
	080 Move rdx, [rbx+52]
	081 Move r9, 0
	082 Move r8, 0
	083 Move rcx, rbx
	084 Call Plant.FindTargetZombie, rcx, rdx, r8
	085 Move rdi, rax
	086 Compare rax, 0
	087 JumpIfEqual {396}
	088 Move xmm6, [rbx+40]
	089 Move xmm7, [rbx+44]
	090 Move rax, [rbx+16]
	091 Move xmm6, xmm6
	092 Move xmm7, xmm7
	093 Multiply xmm6, xmm6, [0x183C33C40]
	094 Multiply xmm7, xmm7, [0x183C33C40]
	095 Add xmm6, xmm6, [rbx+32]
	096 Add xmm7, xmm7, [rbx+36]
	097 Compare rax, 0
	098 JumpIfEqual {407}
	099 Compare [rbx+112], 49
	100 Move r8, [rax+88]
	101 JumpIfEqual {330}
	102 Compare r8, 0
	103 JumpIfEqual {407}
	104 Move rdx, typeof(Reloaded.Services.IAudioService)
	105 Move rcx, 6
	106 Move r9, 20
	107 Call 0x180002040, rcx, rdx, r8, r9
	108 Move rcx, [rbx+24]
	109 Compare rcx, 0
	110 JumpIfEqual {407}
	111 Move xmm3, [0x183C33C4C]
	112 Move rbp, 0
	113 Move rdx, 1
	114 Move stack:0x20, rbp
	115 Move r8, 0xFFFFFFFE
	116 Call Board.ShakeBoard, rcx, rdx, xmm2, r9
	117 Compare [rbx+112], 50
	118 JumpIfEqual {161}
	119 Compare [rdi+304], 1
	120 JumpIfNotEqual {123}
	121 Compare [rbx+136], rbp
	122 JumpIfNotEqual {161}
	123 Compare [rdi+304], rbp
	124 JumpIfNotEqual {155}
	125 Compare [rdi+284], rbp
	126 JumpIfEqual {161}
	127 Compare [rdi+284], 2
	128 JumpIfEqual {139}
	129 Compare [rdi+284], 1
	130 JumpIfNotEqual {149}
	131 Move rax, [rbx+16]
	132 Compare rax, 0
	133 JumpIfEqual {407}
	134 Move r8, [rax+88]
	135 Compare r8, 0
	136 JumpIfEqual {407}
	137 Move r9, 58
	138 Goto {146}
	139 Move rax, [rbx+16]
	140 Compare rax, 0
	141 JumpIfEqual {407}
	142 Move r8, [rax+88]
	143 Compare r8, 0
	144 JumpIfEqual {407}
	145 Move r9, 46
	146 Move rdx, typeof(Reloaded.Services.IAudioService)
	147 Move rcx, 6
	148 Call 0x180002040, rcx, rdx, r8, r9
	149 Move r9, 0
	150 Move r8, 0
	151 Move rdx, 900
	152 Move rcx, rdi
	153 Call Zombie.TakeHelmDamage, rcx, rdx, r8
	154 Goto {166}
	155 Move r9, 0
	156 Move r8, 0
	157 Move rdx, 400
	158 Move rcx, rdi
	159 Call Zombie.TakeShieldDamage, rcx, rdx, r8
	160 Goto {166}
	161 Move r9, 0
	162 Move r8, 0
	163 Move rdx, 1800
	164 Move rcx, rdi
	165 Call Zombie.TakeDamage, rcx, rdx, r8
	166 Move rcx, [rbx+16]
	167 Compare rcx, 0
	168 JumpIfEqual {407}
	169 Move rdx, 0
	170 Call GameplayActivity.IsFirstTimeAdventureMode, rcx, rdx
	171 Compare rax, 0
	172 JumpIfEqual {178}
	173 Move rax, [rbx+24]
	174 Compare rax, 0
	175 JumpIfEqual {407}
	176 Compare [rax+440], 10
	177 JumpIfLessOrEqual {296}
	178 Compare [rbx+112], 3
	179 JumpIfNotEqual {296}
	180 Move rax, [rbx+164]
	181 Add rax, rax, 1
	182 Move [rbx+164], rax
	183 Compare rax, 2
	184 JumpIfEqual {277}
	185 Compare rax, 3
	186 JumpIfEqual {252}
	187 Compare rax, 4
	188 JumpIfEqual {218}
	189 Compare rax, 5
	190 JumpIfLess {296}
	191 Move rax, [rbx+16]
	192 Compare rax, 0
	193 JumpIfEqual {407}
	194 Move r8, [rax+88]
	195 Compare r8, 0
	196 JumpIfEqual {407}
	197 Move rdx, typeof(Reloaded.Services.IAudioService)
	198 Move rcx, 6
	199 Move r9, 4
	200 Call 0x180002040, rcx, rdx, r8, r9
	201 Move rcx, [rbx+24]
	202 Compare rcx, 0
	203 JumpIfEqual {407}
	204 Move stack:0x28, rbp
	205 Move r9, 2
	206 Move xmm2, xmm7
	207 Move stack:0x20, 3
	208 Move xmm1, xmm6
	209 Call Board.AddCoin, rcx, xmm1, r8, r9, stack:0x0
	210 Move rcx, [rbx+24]
	211 Compare rcx, 0
	212 JumpIfEqual {407}
	213 Move r9, 0
	214 Move r8, 1
	215 Move rdx, 8
	216 Call Board.GrantAchievement, rcx, rdx, r8
	217 Goto {296}
	218 Move rax, [rbx+16]
	219 Compare rax, 0
	220 JumpIfEqual {407}
	221 Move r8, [rax+88]
	222 Compare r8, 0
	223 JumpIfEqual {407}
	224 Move rdx, typeof(Reloaded.Services.IAudioService)
	225 Move rcx, 6
	226 Move r9, 4
	227 Call 0x180002040, rcx, rdx, r8, r9
	228 Move rcx, [rbx+24]
	229 Compare rcx, 0
	230 JumpIfEqual {407}
	231 Move xmm1, xmm6
	232 Move stack:0x28, rbp
	233 Subtract xmm1, xmm1, [0x183C33DAC]
	234 Move r9, 1
	235 Move stack:0x20, 3
	236 Move xmm2, xmm7
	237 Call Board.AddCoin, rcx, xmm1, r8, r9, stack:0x0
	238 Move rcx, [rbx+24]
	239 Compare rcx, 0
	240 JumpIfEqual {407}
	241 Move stack:0x28, rbp
	242 Move r9, 1
	243 Move xmm2, xmm7
	244 Move stack:0x20, 3
	245 Move xmm1, xmm6
	246 Call Board.AddCoin, rcx, xmm1, r8, r9, stack:0x0
	247 Move rcx, [rbx+24]
	248 Compare rcx, 0
	249 JumpIfEqual {407}
	250 Add xmm6, xmm6, [0x183C33DAC]
	251 Goto {290}
	252 Move rax, [rbx+16]
	253 Compare rax, 0
	254 JumpIfEqual {407}
	255 Move r8, [rax+88]
	256 Compare r8, 0
	257 JumpIfEqual {407}
	258 Move rdx, typeof(Reloaded.Services.IAudioService)
	259 Move rcx, 6
	260 Move r9, 4
	261 Call 0x180002040, rcx, rdx, r8, r9
	262 Move rcx, [rbx+24]
	263 Compare rcx, 0
	264 JumpIfEqual {407}
	265 Move xmm1, xmm6
	266 Move stack:0x28, rbp
	267 Subtract xmm1, xmm1, [0x183C33ED4]
	268 Move r9, 1
	269 Move stack:0x20, 3
	270 Move xmm2, xmm7
	271 Call Board.AddCoin, rcx, xmm1, r8, r9, stack:0x0
	272 Move rcx, [rbx+24]
	273 Compare rcx, 0
	274 JumpIfEqual {407}
	275 Add xmm6, xmm6, [0x183C33ED4]
	276 Goto {290}
	277 Move rax, [rbx+16]
	278 Compare rax, 0
	279 JumpIfEqual {407}
	280 Move r8, [rax+88]
	281 Compare r8, 0
	282 JumpIfEqual {407}
	283 Move rdx, typeof(Reloaded.Services.IAudioService)
	284 Move rcx, 6
	285 Move r9, 4
	286 Call 0x180002040, rcx, rdx, r8, r9
	287 Move rcx, [rbx+24]
	288 Compare rcx, 0
	289 JumpIfEqual {407}
	290 Move stack:0x28, rbp
	291 Move r9, 1
	292 Move xmm2, xmm7
	293 Move stack:0x20, 3
	294 Move xmm1, xmm6
	295 Call Board.AddCoin, rcx, xmm1, r8, r9, stack:0x0
	296 Compare [rbx+112], 50
	297 JumpIfEqual {396}
	298 Compare [rbx+52], 4
	299 JumpIfEqual {315}
	300 Compare [rbx+136], 29
	301 JumpIfEqual {315}
	302 Compare [rbx+52], rbp
	303 JumpIfEqual {400}
	304 Compare [rbx+136], 28
	305 JumpIfEqual {400}
	306 Move rcx, typeof(Reloaded.Gameplay.Common)
	307 Compare [rcx+228], rbp
	308 JumpIfNotEqual {310}
	309 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	310 Move rdx, 0
	311 Move rcx, 2
	312 Call Common.Rand, rcx, rdx
	313 Compare rax, 0
	314 JumpIfEqual {400}
	315 Subtract [rbx+52], [rbx+52], 1
	316 Move rdx, 0
	317 Move rcx, rbx
	318 Move [rbx+136], 28
	319 Call Plant.CalcRenderOrder, rcx, rdx
	320 Move [rbx+56], rax
	321 Move xmm7, stack:0x50
	322 Move xmm6, stack:0x60
	323 Move rdi, stack:0x90
	324 Move rsi, stack:0x88
	325 Move rbp, stack:0x80
	326 ShiftStack 112
	327 Move rbx, stack:0x0
	328 ShiftStack 8
	329 Return 
	330 Compare r8, 0
	331 JumpIfEqual {407}
	332 Move rdx, typeof(Reloaded.Services.IAudioService)
	333 Move rcx, 6
	334 Move r9, 55
	335 Call 0x180002040, rcx, rdx, r8, r9
	336 Move r8, [rbx+16]
	337 Compare r8, 0
	338 JumpIfEqual {407}
	339 Move r8, [r8+88]
	340 Compare r8, 0
	341 JumpIfEqual {407}
	342 Move rdx, typeof(Reloaded.Services.IAudioService)
	343 Move rcx, 25
	344 Move r9, 14
	345 Call 0x180002040, rcx, rdx, r8, r9
	346 Move rax, [rbx+16]
	347 Compare rax, 0
	348 JumpIfEqual {407}
	349 Move r8, [rax+120]
	350 Compare r8, 0
	351 JumpIfEqual {407}
	352 Move rdx, typeof(Reloaded.Input.IInputService)
	353 Move rcx, 23
	354 Move r9, 1
	355 Call 0x180002040, rcx, rdx, r8, r9
	356 Move rdi, [rbx+24]
	357 Move r8, 0
	358 Move rdx, 0
	359 Move rcx, rbx
	360 Call Plant.GetDamageRangeFlags, rcx, rdx
	361 Or rax, rax, 2
	362 Compare rdi, 0
	363 JumpIfEqual {407}
	364 Move rdx, [rbx+52]
	365 Move rbp, 0
	366 Move stack:0x40, rbp
	367 Move xmm3, xmm7
	368 Move stack:0x38, rax
	369 Move xmm2, xmm6
	370 Move stack:0x30, 1
	371 Move rcx, rdi
	372 Move stack:0x28, 1
	373 Move stack:0x20, 90
	374 Call Board.KillAllZombiesInRadius, rcx, xmm1, xmm2, r9, stack:0x0, stack:0x8, stack:0x10, stack:0x18
	375 Move rcx, [rbx+16]
	376 Compare rcx, 0
	377 JumpIfEqual {407}
	378 Move stack:0x28, rbp
	379 Move r9, 0x61A80
	380 Move xmm2, xmm7
	381 Move stack:0x20, 4
	382 Move xmm1, xmm6
	383 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	384 Move rcx, [rbx+24]
	385 Compare rcx, 0
	386 JumpIfEqual {407}
	387 Move xmm3, [0x183C33C4C]
	388 Move rdx, 3
	389 Move r8, 0xFFFFFFFC
	390 Move stack:0x20, rbp
	391 Call Board.ShakeBoard, rcx, rdx, xmm2, r9
	392 Move rdx, 0
	393 Move rcx, rbx
	394 Call Plant.Die, rcx, rdx
	395 Goto {321}
	396 Compare rsi, 28
	397 JumpIfEqual {315}
	398 Compare rsi, 29
	399 JumpIfNotEqual {321}
	400 Move rdx, 0
	401 Move [rbx+136], 29
	402 Move rcx, rbx
	403 Call Plant.CalcRenderOrder, rcx, rdx
	404 Add [rbx+52], [rbx+52], 1
	405 Move [rbx+56], rax
	406 Goto {321}
	407 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
