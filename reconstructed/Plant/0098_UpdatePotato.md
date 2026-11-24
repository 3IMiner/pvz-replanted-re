# System.Void UpdatePotato()

- 类：`Plant`
- 汇编行数：673

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,90h
	cmp byte ptr [184EEB65Ch],0
	mov rbx,rcx
	jne short 00000001806BA714h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C97ED8h]
	call 00000001804FEB70h
	lea rcx,[184C94FA0h]
	call 00000001804FEB70h
	lea rcx,[184C96FA8h]
	call 00000001804FEB70h
	lea rcx,[184C92EB8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB65Ch],1
	cmp dword ptr [rbx+88h],0
	mov [rsp+0B0h],rdi
	mov [rsp+88h],r14
	movaps [rsp+70h],xmm6
	je near ptr 00000001806BAB84h
	cmp dword ptr [rbx+88h],0Fh
	je near ptr 00000001806BA99Eh
	cmp dword ptr [rbx+88h],10h
	jne near ptr 00000001806BA974h
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	test rax,rax
	jne near ptr 00000001806BA992h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BACB8h
	mov edx,[rbx+0F4h]
	xor r8d,r8d
	mov [rsp+0B8h],r13
	call 00000001807E1430h
	mov r13,rax
	test rax,rax
	je near ptr 00000001806BA96Ch
	cmp byte ptr [184EEB663h],0
	mov [rsp+0A0h],rbp
	mov [rsp+80h],r15
	jne short 00000001806BA7DDh
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	mov byte ptr [184EEB663h],1
	xorps xmm0,xmm0
	mov [rsp+0A8h],rsi
	xorps xmm1,xmm1
	xor r8d,r8d
	xor edx,edx
	mov rcx,rbx
	movups [rsp+50h],xmm0
	movups [rsp+40h],xmm1
	call 00000001806B12F0h
	xor r9d,r9d
	lea rcx,[rsp+60h]
	xor r8d,r8d
	mov rdx,rbx
	mov r15d,eax
	call 00000001806B1660h
	mov rcx,[rbx+18h]
	xor r14d,r14d
	mov edi,3E8h
	mov ebp,r14d
	mov edx,r14d
	movups xmm0,[rax]
	movups [rsp+50h],xmm0
	test rcx,rcx
	je near ptr 00000001806BACBEh
	nop dword ptr [rax+rax]
	mov rax,[rcx+70h]
	test rax,rax
	je near ptr 00000001806BACBEh
	cmp edx,[rax+28h]
	jge near ptr 00000001806BA90Bh
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806BACBEh
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806BACBEh
	mov r8,[184C81528h]
	mov edx,ebp
	call 0000000182449330h
	mov rsi,rax
	test rax,rax
	je near ptr 00000001806BACBEh
	mov ecx,[rbx+34h]
	cmp [rax+34h],ecx
	jne short 00000001806BA8F5h
	xor r8d,r8d
	mov edx,r15d
	mov rcx,rax
	call 00000001806F12F0h
	test al,al
	je short 00000001806BA8F5h
	xor r8d,r8d
	lea rcx,[rsp+60h]
	mov rdx,rsi
	call 00000001806F2D70h
	mov rcx,[184C2AFC0h]
	movups xmm0,[rax]
	movups [rsp+40h],xmm0
	cmp [rcx+0E4h],r14d
	jne short 00000001806BA8D1h
	call 00000001804FEEB0h
	xor r8d,r8d
	lea rdx,[rsp+40h]
	lea rcx,[rsp+50h]
	call 00000001806CBAA0h
	mov ecx,eax
	neg ecx
	cmp edi,ecx
	jle short 00000001806BA8F5h
	mov edi,eax
	neg edi
	test edi,edi
	cmovle edi,r14d
	mov rcx,[rbx+18h]
	inc ebp
	mov edx,ebp
	test rcx,rcx
	je near ptr 00000001806BACBEh
	jmp near ptr 00000001806BA840h
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r14d
	jne short 00000001806BA920h
	call 00000001804FEEB0h
	mov [rsp+30h],r14
	mov r9d,0Ah
	mov dword ptr [rsp+28h],1
	mov r8d,edi
	mov edx,32h
	mov dword ptr [rsp+20h],3
	mov ecx,0C8h
	call 00000001806CC120h
	mov rsi,[rsp+0A8h]
	mov rbp,[rsp+0A0h]
	mov r15,[rsp+80h]
	mov [r13+80h],eax
	mov r13,[rsp+0B8h]
	movaps xmm6,[rsp+70h]
	mov r14,[rsp+88h]
	mov rdi,[rsp+0B0h]
	add rsp,90h
	pop rbx
	ret
	xor edx,edx
	mov rcx,rbx
	call 00000001806AD780h
	jmp short 00000001806BA974h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BACB8h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle short 00000001806BA974h
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806BA9D1h
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DB8h]
	xor r8d,r8d
	movss xmm0,dword ptr [183C33DB4h]
	call 00000001806CBD40h
	cmp byte ptr [184EEB658h],0
	movaps xmm6,xmm0
	mov rdi,[184C92EB8h]
	jne short 00000001806BAA1Bh
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806BACB8h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BACB8h
	xor r14d,r14d
	movaps xmm3,xmm6
	mov [rsp+28h],r14
	xor r8d,r8d
	mov rdx,rax
	mov [rsp+20h],r14d
	call 00000001807C8270h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BACB8h
	mov edx,[rbx+70h]
	xor r8d,r8d
	call 00000001807DD8A0h
	test rax,rax
	je near ptr 00000001806BACB8h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BACB8h
	mov r9d,[rbx+38h]
	xorps xmm2,xmm2
	mov eax,[rax+40h]
	add r9d,2
	mov [rsp+28h],r14
	xorps xmm1,xmm1
	mov [rsp+20h],eax
	call 00000001807D96D0h
	mov rdi,rax
	test rax,rax
	je near ptr 00000001806BACB8h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rax
	call 00000001806CAF80h
	subss xmm6,dword ptr [183C33D94h]
	xor r8d,r8d
	mov rcx,rdi
	movaps xmm1,xmm6
	call 00000001806CAEE0h
	mov rdx,[184C94FA0h]
	xor r8d,r8d
	mov rcx,rdi
	call 00000001806CAC10h
	mov dword ptr [rdi+80h],0Ah
	xor r8d,r8d
	mov rdx,[184C94FA0h]
	mov rcx,rdi
	call 000000018060F880h
	mov rdx,[184C94FA0h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rdi
	call 000000018060F880h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BACB8h
	xor r8d,r8d
	mov rdx,rdi
	call 00000001807E13A0h
	mov rdx,[rbx+140h]
	xor r9d,r9d
	mov [rbx+0F4h],eax
	mov rcx,rdi
	mov r8,[184C96FA8h]
	call 000000018060F880h
	xor edx,edx
	mov dword ptr [rbx+88h],10h
	mov ecx,190h
	call 00000001806CBE80h
	add eax,190h
	mov [rbx+0FCh],eax
	jmp near ptr 00000001806BA974h
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806BA974h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BACB8h
	movd xmm2,dword ptr [rbx+2Ch]
	xor r14d,r14d
	movd xmm1,dword ptr [rbx+28h]
	mov r9d,[rbx+38h]
	cvtdq2ps xmm2,xmm2
	mov [rsp+28h],r14
	mov dword ptr [rsp+20h],31h
	cvtdq2ps xmm1,xmm1
	mulss xmm2,dword ptr [183C33C40h]
	mulss xmm1,dword ptr [183C33C40h]
	addss xmm2,dword ptr [rbx+24h]
	addss xmm1,dword ptr [rbx+20h]
	call 00000001807D9B50h
	cmp [184EEB658h],r14b
	mov rdi,[184C97ED8h]
	jne short 00000001806BAC10h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806BACB8h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je short 00000001806BACB8h
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806BACB8h
	movss xmm3,dword ptr [183C33EE4h]
	xor r8d,r8d
	mov [rsp+28h],r14
	mov rdx,rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov r8,[rbx+10h]
	mov dword ptr [rbx+88h],0Fh
	test r8,r8
	je short 00000001806BACB8h
	mov r8,[r8+58h]
	test r8,r8
	je short 00000001806BACB8h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,50h
	call 0000000180002040h
	jmp near ptr 00000001806BA974h
	call 00000001804FEE20h
	int 3
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -144
	004 Compare [0x184EEB65C], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {20}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C75168]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C97ED8]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C94FA0]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184C96FA8]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C92EB8]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 Move [0x184EEB65C], 1
	020 Compare [rbx+136], 0
	021 Move stack:0xB0, rdi
	022 Move stack:0x88, r14
	023 Move stack:0x70, xmm6
	024 JumpIfEqual {272}
	025 Compare [rbx+136], 15
	026 JumpIfEqual {166}
	027 Compare [rbx+136], 16
	028 JumpIfNotEqual {155}
	029 Move rdx, [rbx+52]
	030 Move r9, 0
	031 Move r8, 0
	032 Move rcx, rbx
	033 Call Plant.FindTargetZombie, rcx, rdx, r8
	034 Compare rax, 0
	035 JumpIfNotEqual {162}
	036 Move rcx, [rbx+16]
	037 Compare rcx, 0
	038 JumpIfEqual {334}
	039 Move rdx, [rbx+244]
	040 Move r8, 0
	041 Move stack:0xB8, r13
	042 Call GameplayActivity.ReanimationTryToGet, rcx, rdx
	043 Move r13, rax
	044 Compare rax, 0
	045 JumpIfEqual {154}
	046 Compare [0x184EEB663], 0
	047 Move stack:0xA0, rbp
	048 Move stack:0x80, r15
	049 JumpIfNotEqual {57}
	050 LoadAddress rcx, [0x184C2AFC0]
	051 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	052 LoadAddress rcx, [0x184C81450]
	053 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	054 LoadAddress rcx, [0x184C81528]
	055 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	056 Move [0x184EEB663], 1
	057 Move xmm0, 0
	058 Move stack:0xA8, rsi
	059 Move xmm1, 0
	060 Move r8, 0
	061 Move rdx, 0
	062 Move rcx, rbx
	063 Move stack:0x50, xmm0
	064 Move stack:0x40, xmm1
	065 Call Plant.GetDamageRangeFlags, rcx, rdx
	066 Move r9, 0
	067 LoadAddress rcx, stack:0x60
	068 Move r8, 0
	069 Move rdx, rbx
	070 Move r15, rax
	071 Call Plant.GetPlantAttackRect, rcx, rdx
	072 Move rcx, [rbx+24]
	073 Move r14, 0
	074 Move rdi, 1000
	075 Move rbp, r14
	076 Move rdx, r14
	077 Move xmm0, [rax]
	078 Move stack:0x50, xmm0
	079 Compare rcx, 0
	080 JumpIfEqual {336}
	081 Nop 
	082 Move rax, [rcx+112]
	083 Compare rax, 0
	084 JumpIfEqual {336}
	085 Compare rdx, [rax+40]
	086 JumpIfGreaterOrEqual {138}
	087 Move rax, [rbx+24]
	088 Compare rax, 0
	089 JumpIfEqual {336}
	090 Move rcx, [rax+112]
	091 Compare rcx, 0
	092 JumpIfEqual {336}
	093 Move r8, [0x184C81528]
	094 Move rdx, rbp
	095 Call 0x182449330, rcx, rdx
	096 Move rsi, rax
	097 Compare rax, 0
	098 JumpIfEqual {336}
	099 Move rcx, [rbx+52]
	100 Compare [rax+52], rcx
	101 JumpIfNotEqual {132}
	102 Move r8, 0
	103 Move rdx, r15
	104 Move rcx, rax
	105 Call Zombie.EffectedByDamage, rcx, rdx
	106 Compare rax, 0
	107 JumpIfEqual {132}
	108 Move r8, 0
	109 LoadAddress rcx, stack:0x60
	110 Move rdx, rsi
	111 Call Zombie.GetZombieRect, rcx, rdx
	112 Move rcx, typeof(Reloaded.Gameplay.Common)
	113 Move xmm0, [rax]
	114 Move stack:0x40, xmm0
	115 Compare [rcx+228], r14
	116 JumpIfNotEqual {118}
	117 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	118 Move r8, 0
	119 LoadAddress rdx, stack:0x40
	120 LoadAddress rcx, stack:0x50
	121 Call Common.GetRectOverlap, rcx, rdx, r8
	122 Move rcx, rax
	123 Neg rcx
	124 Compare rdi, rcx
	125 JumpIfLessOrEqual {132}
	126 Move rdi, rax
	127 Neg rdi
	128 Compare rdi, 0
	129 JumpIfGreater {131}
	130 Move rdi, r14
	131 Nop 
	132 Move rcx, [rbx+24]
	133 Add rbp, rbp, 1
	134 Move rdx, rbp
	135 Compare rcx, 0
	136 JumpIfEqual {336}
	137 Goto {82}
	138 Move rcx, typeof(Reloaded.Gameplay.Common)
	139 Compare [rcx+228], r14
	140 JumpIfNotEqual {142}
	141 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	142 Move stack:0x30, r14
	143 Move r9, 10
	144 Move stack:0x28, 1
	145 Move r8, rdi
	146 Move rdx, 50
	147 Move stack:0x20, 3
	148 Move rcx, 200
	149 Call Common.TodAnimateCurve, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	150 Move rsi, stack:0xA8
	151 Move rbp, stack:0xA0
	152 Move r15, stack:0x80
	153 Move [r13+128], rax
	154 Move r13, stack:0xB8
	155 Move xmm6, stack:0x70
	156 Move r14, stack:0x88
	157 Move rdi, stack:0xB0
	158 ShiftStack 144
	159 Move rbx, stack:0x0
	160 ShiftStack 8
	161 Return 
	162 Move rdx, 0
	163 Move rcx, rbx
	164 Call Plant.DoSpecial, rcx, rdx
	165 Goto {155}
	166 Move rcx, [rbx+320]
	167 Compare rcx, 0
	168 JumpIfEqual {334}
	169 Move r8, 0
	170 Move rdx, 0
	171 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	172 Compare rax, 0
	173 JumpIfLessOrEqual {155}
	174 Move rcx, typeof(Reloaded.Gameplay.Common)
	175 Compare [rcx+228], 0
	176 JumpIfNotEqual {178}
	177 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	178 Move xmm1, [0x183C33DB8]
	179 Move r8, 0
	180 Move xmm0, [0x183C33DB4]
	181 Call Common.RandRangeFloat, xmm0, xmm1, r8
	182 Compare [0x184EEB658], 0
	183 Move xmm6, xmm0
	184 Move rdi, "anim_armed"
	185 JumpIfNotEqual {191}
	186 LoadAddress rcx, [0x184C92A80]
	187 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	188 LoadAddress rcx, [0x184C911F8]
	189 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	190 Move [0x184EEB658], 1
	191 Compare rdi, 0
	192 JumpIfEqual {334}
	193 Move r8, ""
	194 Move r9, 0
	195 Move rdx, "anim_"
	196 Move rcx, rdi
	197 Call String.Replace, rcx, rdx, r8
	198 Move rcx, [rbx+320]
	199 Compare rcx, 0
	200 JumpIfEqual {334}
	201 Move r14, 0
	202 Move xmm3, xmm6
	203 Move stack:0x28, r14
	204 Move r8, 0
	205 Move rdx, rax
	206 Move stack:0x20, r14
	207 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	208 Move rcx, [rbx+16]
	209 Compare rcx, 0
	210 JumpIfEqual {334}
	211 Move rdx, [rbx+112]
	212 Move r8, 0
	213 Call GameplayActivity.GetPlantDefinition, rcx, rdx
	214 Compare rax, 0
	215 JumpIfEqual {334}
	216 Move rcx, [rbx+16]
	217 Compare rcx, 0
	218 JumpIfEqual {334}
	219 Move r9, [rbx+56]
	220 Move xmm2, 0
	221 Move rax, [rax+64]
	222 Add r9, r9, 2
	223 Move stack:0x28, r14
	224 Move xmm1, 0
	225 Move stack:0x20, rax
	226 Call GameplayActivity.AddReanimation, rcx, xmm1, r8, r9, stack:0x0
	227 Move rdi, rax
	228 Compare rax, 0
	229 JumpIfEqual {334}
	230 Move r8, 0
	231 Move rdx, 0
	232 Move rcx, rax
	233 Call Reanimation.set_mLoopType, rcx, rdx
	234 Subtract xmm6, xmm6, [0x183C33D94]
	235 Move r8, 0
	236 Move rcx, rdi
	237 Move xmm1, xmm6
	238 Call Reanimation.set_mAnimRate, rcx, rdx
	239 Move rdx, "anim_glow"
	240 Move r8, 0
	241 Move rcx, rdi
	242 Call Reanimation.SetFramesForLayer, rcx, rdx
	243 Move [rdi+128], 10
	244 Move r8, 0
	245 Move rdx, "anim_glow"
	246 Move rcx, rdi
	247 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	248 Move rdx, "anim_glow"
	249 Move r9, 0
	250 Move r8, 0
	251 Move rcx, rdi
	252 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	253 Move rcx, [rbx+16]
	254 Compare rcx, 0
	255 JumpIfEqual {334}
	256 Move r8, 0
	257 Move rdx, rdi
	258 Call GameplayActivity.ReanimationGetID, rcx, rdx
	259 Move rdx, [rbx+320]
	260 Move r9, 0
	261 Move [rbx+244], rax
	262 Move rcx, rdi
	263 Move r8, "anim_light"
	264 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	265 Move rdx, 0
	266 Move [rbx+136], 16
	267 Move rcx, 400
	268 Call Common.Rand, rcx, rdx
	269 Add rax, rax, 400
	270 Move [rbx+252], rax
	271 Goto {155}
	272 Compare [rbx+160], 0
	273 JumpIfNotEqual {155}
	274 Move rcx, [rbx+16]
	275 Compare rcx, 0
	276 JumpIfEqual {334}
	277 Move xmm2, [rbx+44]
	278 Move r14, 0
	279 Move xmm1, [rbx+40]
	280 Move r9, [rbx+56]
	281 Move xmm2, xmm2
	282 Move stack:0x28, r14
	283 Move stack:0x20, 49
	284 Move xmm1, xmm1
	285 Multiply xmm2, xmm2, [0x183C33C40]
	286 Multiply xmm1, xmm1, [0x183C33C40]
	287 Add xmm2, xmm2, [rbx+36]
	288 Add xmm1, xmm1, [rbx+32]
	289 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	290 Compare [0x184EEB658], r14
	291 Move rdi, "anim_rise"
	292 JumpIfNotEqual {298}
	293 LoadAddress rcx, [0x184C92A80]
	294 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	295 LoadAddress rcx, [0x184C911F8]
	296 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	297 Move [0x184EEB658], 1
	298 Compare rdi, 0
	299 JumpIfEqual {334}
	300 Move r8, ""
	301 Move r9, 0
	302 Move rdx, "anim_"
	303 Move rcx, rdi
	304 Call String.Replace, rcx, rdx, r8
	305 Move rcx, [rbx+320]
	306 Move rdi, rax
	307 Compare rcx, 0
	308 JumpIfEqual {334}
	309 Move xmm1, [0x183C33DBC]
	310 Move r9, 0
	311 Move r8, 0
	312 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	313 Move rcx, [rbx+320]
	314 Compare rcx, 0
	315 JumpIfEqual {334}
	316 Move xmm3, [0x183C33EE4]
	317 Move r8, 0
	318 Move stack:0x28, r14
	319 Move rdx, rdi
	320 Move stack:0x20, 3
	321 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	322 Move r8, [rbx+16]
	323 Move [rbx+136], 15
	324 Compare r8, 0
	325 JumpIfEqual {334}
	326 Move r8, [r8+88]
	327 Compare r8, 0
	328 JumpIfEqual {334}
	329 Move rdx, typeof(Reloaded.Services.IAudioService)
	330 Move rcx, 6
	331 Move r9, 80
	332 Call 0x180002040, rcx, rdx, r8, r9
	333 Goto {155}
	334 Call 0x1804FEE20, rcx, rdx, r8, r9
	335 Interrupt 
	336 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
