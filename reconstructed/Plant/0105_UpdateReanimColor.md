# System.Void UpdateReanimColor()

- 类：`Plant`
- 汇编行数：883

## 反汇编

```asm

Disassembly:
	mov [rsp+20h],rbx
	push rbp
	mov rbp,rsp
	sub rsp,60h
	cmp byte ptr [184EEB66Dh],0
	mov rbx,rcx
	jne short 00000001806BB134h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C7F518h]
	call 00000001804FEB70h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	mov byte ptr [184EEB66Dh],1
	cmp qword ptr [rbx+18h],0
	je near ptr 00000001806BB7D1h
	cmp byte ptr [rbx+137h],0
	je near ptr 00000001806BB7D1h
	mov [rsp+78h],rdi
	mov rcx,[184C2D478h]
	mov rdi,[rbx+140h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806BB16Dh
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832770h
	test al,al
	jne near ptr 00000001806BB7CCh
	mov [rsp+70h],rsi
	mov [rsp+80h],r14
	movaps [rsp+50h],xmm6
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	xor r8d,r8d
	xor edx,edx
	call 000000018065EF70h
	mov edi,eax
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806BB7DFh
	mov rax,[rax+0A8h]
	test rax,rax
	je near ptr 00000001806BB7DFh
	xor r14d,r14d
	cmp dword ptr [rax+7Ch],3
	jne short 00000001806BB22Bh
	mov rax,[rbx+18h]
	xor edx,edx
	mov rcx,[rax+0A8h]
	mov rsi,[rax+78h]
	mov ecx,[rcx+84h]
	call 00000001806BE7D0h
	test rsi,rsi
	je near ptr 00000001806BB7DFh
	mov r8,[184C7F518h]
	mov edx,eax
	mov rcx,rsi
	call 0000000182448850h
	test rax,rax
	je short 00000001806BB22Bh
	mov ecx,[rbx+74h]
	cmp [rax+74h],ecx
	jne short 00000001806BB22Bh
	mov ecx,[rbx+34h]
	cmp [rax+34h],ecx
	jne short 00000001806BB22Bh
	movdqa xmm2,[183C34040h]
	jmp near ptr 00000001806BB464h
	cmp edi,2Fh
	jne short 00000001806BB285h
	cmp dword ptr [rbx+70h],22h
	jne short 00000001806BB285h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov edx,[rbx+74h]
	call 0000000180662310h
	test al,al
	jne near ptr 00000001806BB36Dh
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	mov edx,[rbx+74h]
	xor r9d,r9d
	mov r8d,[rbx+34h]
	dec edx
	call 0000000180662310h
	test al,al
	jne near ptr 00000001806BB36Dh
	jmp near ptr 00000001806BB3DBh
	cmp edi,28h
	jne short 00000001806BB29Bh
	cmp dword ptr [rbx+70h],7
	jne near ptr 00000001806BB367h
	mov al,1
	jmp near ptr 00000001806BB369h
	cmp edi,2Ch
	jne short 00000001806BB2B1h
	cmp dword ptr [rbx+70h],27h
	jne near ptr 00000001806BB367h
	mov al,1
	jmp near ptr 00000001806BB369h
	cmp edi,29h
	jne short 00000001806BB2C7h
	cmp dword ptr [rbx+70h],1
	jne near ptr 00000001806BB367h
	mov al,1
	jmp near ptr 00000001806BB369h
	cmp edi,2Eh
	jne short 00000001806BB2DDh
	cmp dword ptr [rbx+70h],15h
	jne near ptr 00000001806BB367h
	mov al,1
	jmp near ptr 00000001806BB369h
	cmp edi,2Fh
	jne short 00000001806BB30Ch
	cmp dword ptr [rbx+70h],22h
	jne short 00000001806BB367h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov edx,[rbx+74h]
	call 0000000180662310h
	test al,al
	je short 00000001806BB367h
	mov al,1
	jmp short 00000001806BB369h
	cmp edi,2Dh
	jne short 00000001806BB31Bh
	cmp dword ptr [rbx+70h],1Fh
	jne short 00000001806BB367h
	mov al,1
	jmp short 00000001806BB369h
	cmp edi,2Ah
	jne short 00000001806BB32Ah
	cmp dword ptr [rbx+70h],0Ah
	jne short 00000001806BB367h
	mov al,1
	jmp short 00000001806BB369h
	cmp edi,2Bh
	jne short 00000001806BB367h
	cmp dword ptr [rbx+70h],10h
	jne short 00000001806BB367h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	mov r8d,[rbx+34h]
	mov r9d,6
	mov edx,[rbx+74h]
	mov [rsp+20h],r14
	call 000000018065F2A0h
	test rax,rax
	je short 00000001806BB363h
	cmp [rax+70h],edi
	je short 00000001806BB367h
	mov al,1
	jmp short 00000001806BB369h
	xor al,al
	test al,al
	je short 00000001806BB3D6h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	mov r8d,[rbx+34h]
	mov r9d,edi
	mov edx,[rbx+74h]
	mov [rsp+20h],r14
	call 00000001806565B0h
	test eax,eax
	jne short 00000001806BB3D6h
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806BB7DFh
	mov rcx,[184C2AFC0h]
	mov edi,[rax+1ECh]
	cmp [rcx+0E4h],r14d
	jne short 00000001806BB3BAh
	call 00000001804FEEB0h
	xor r9d,r9d
	lea rcx,[rbp-20h]
	mov r8d,5Ah
	mov edx,edi
	call 00000001806CB9C0h
	movups xmm2,[rax]
	jmp near ptr 00000001806BB464h
	cmp edi,2Fh
	jne short 00000001806BB44Ch
	cmp dword ptr [rbx+70h],22h
	jne short 00000001806BB44Ch
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	mov edx,[rbx+74h]
	mov r9d,2Fh
	mov r8d,[rbx+34h]
	dec edx
	mov [rsp+20h],r14
	call 00000001806565B0h
	test eax,eax
	jne short 00000001806BB44Ch
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806BB7DFh
	mov rcx,[184C2AFC0h]
	mov edi,[rax+1ECh]
	cmp [rcx+0E4h],r14d
	jne short 00000001806BB433h
	call 00000001804FEEB0h
	xor r9d,r9d
	lea rcx,[rbp-20h]
	mov r8d,5Ah
	mov edx,edi
	call 00000001806CB9C0h
	movups xmm2,[rax]
	jmp short 00000001806BB464h
	cmp dword ptr [rbx+70h],31h
	je short 00000001806BB45Ch
	movdqa xmm2,[183C33C90h]
	jmp short 00000001806BB464h
	movdqa xmm2,[183C33F80h]
	mov rcx,[rbx+140h]
	movaps xmm0,xmm2
	shufps xmm0,xmm2,55h
	movaps xmm1,xmm2
	shufps xmm1,xmm2,0AAh
	movss dword ptr [rbp-20h],xmm2
	shufps xmm2,xmm2,0FFh
	movss dword ptr [rbp-14h],xmm2
	movss dword ptr [rbp-1Ch],xmm0
	movss dword ptr [rbp-18h],xmm1
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	movups xmm0,[rbp-20h]
	xor r9d,r9d
	lea rdx,[rbp-20h]
	xor r8d,r8d
	movdqa [rbp-20h],xmm0
	call 00000001807CAB40h
	movss xmm6,dword ptr [183C33C6Ch]
	cmp [rbx+138h],r14b
	jne near ptr 00000001806BB645h
	cmp [rbx+108h],r14d
	jg near ptr 00000001806BB58Ah
	cmp [rbx+104h],r14d
	jg short 00000001806BB4FFh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	xor r9d,r9d
	xor r8d,r8d
	xor edx,edx
	call 00000001807CAC30h
	jmp near ptr 00000001806BB6C1h
	cmp dword ptr [rbx+12Ch],30h
	mov edi,80h
	mov rcx,[184C2AFC0h]
	mov eax,0FFh
	mov esi,[rbx+104h]
	cmovne edi,eax
	cmp [rcx+0E4h],r14d
	jne short 00000001806BB52Eh
	call 00000001804FEEB0h
	lea ecx,[rsi+rsi*2]
	xor r9d,r9d
	mov r8d,edi
	xor edx,edx
	call 00000001806CB700h
	mov rcx,[rbx+140h]
	movd xmm0,eax
	movd xmm1,eax
	movd xmm2,eax
	cvtdq2ps xmm0,xmm0
	cvtdq2ps xmm1,xmm1
	cvtdq2ps xmm2,xmm2
	divss xmm0,xmm6
	divss xmm1,xmm6
	divss xmm2,xmm6
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	movss dword ptr [rbp-20h],xmm0
	movss dword ptr [rbp-1Ch],xmm1
	movss dword ptr [rbp-18h],xmm2
	mov dword ptr [rbp-14h],3F800000h
	jmp near ptr 00000001806BB617h
	mov rcx,[184C2AFC0h]
	mov edi,[rbx+108h]
	cmp [rcx+0E4h],r14d
	jne short 00000001806BB5A5h
	call 00000001804FEEB0h
	mov eax,51EB851Fh
	mov [rsp+30h],r14
	imul edi
	mov dword ptr [rsp+28h],9
	xor r9d,r9d
	sar edx,4
	mov ecx,32h
	mov eax,edx
	mov dword ptr [rsp+20h],80h
	shr eax,1Fh
	add edx,eax
	imul eax,edx,32h
	xor edx,edx
	sub edi,eax
	mov r8d,edi
	call 00000001806CC120h
	mov rcx,[rbx+140h]
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	divss xmm0,xmm6
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	movss dword ptr [rbp-14h],xmm0
	mov dword ptr [rbp-20h],3F800000h
	mov dword ptr [rbp-1Ch],3F800000h
	mov dword ptr [rbp-18h],3F800000h
	xor r9d,r9d
	lea rdx,[rbp-20h]
	xor r8d,r8d
	call 00000001807CAD50h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	xor r9d,r9d
	xor r8d,r8d
	mov dl,1
	call 00000001807CAC30h
	jmp short 00000001806BB6C1h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	movdqa xmm0,[183C34030h]
	lea rdx,[rbp-20h]
	xor r9d,r9d
	movaps [rbp-20h],xmm0
	xor r8d,r8d
	call 00000001807CAD50h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	xor r9d,r9d
	xor r8d,r8d
	mov dl,1
	call 00000001807CAC30h
	cmp dword ptr [rbx+12Ch],30h
	jne short 00000001806BB6C1h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	movdqa xmm0,[183C34020h]
	lea rdx,[rbp-20h]
	xor r9d,r9d
	movaps [rbp-20h],xmm0
	xor r8d,r8d
	call 00000001807CAD50h
	cmp [rbx+108h],r14d
	jg short 00000001806BB6E1h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BB7DFh
	xor dl,dl
	jmp near ptr 00000001806BB799h
	mov rcx,[184C2AFC0h]
	mov edi,[rbx+108h]
	cmp [rcx+0E4h],r14d
	jne short 00000001806BB6FCh
	call 00000001804FEEB0h
	mov eax,51EB851Fh
	mov [rsp+30h],r14
	imul edi
	mov dword ptr [rsp+28h],9
	xor r9d,r9d
	sar edx,4
	mov ecx,32h
	mov eax,edx
	mov dword ptr [rsp+20h],80h
	shr eax,1Fh
	add edx,eax
	imul eax,edx,32h
	xor edx,edx
	sub edi,eax
	mov r8d,edi
	call 00000001806CC120h
	mov rcx,[rbx+140h]
	movd xmm0,eax
	movd xmm1,eax
	movd xmm2,eax
	cvtdq2ps xmm0,xmm0
	cvtdq2ps xmm1,xmm1
	cvtdq2ps xmm2,xmm2
	divss xmm0,xmm6
	divss xmm1,xmm6
	divss xmm2,xmm6
	test rcx,rcx
	je short 00000001806BB7DFh
	xor r9d,r9d
	movss dword ptr [rbp-20h],xmm0
	xor r8d,r8d
	movss dword ptr [rbp-1Ch],xmm1
	lea rdx,[rbp-20h]
	movss dword ptr [rbp-18h],xmm2
	mov dword ptr [rbp-14h],3F800000h
	call 00000001807CADF0h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806BB7DFh
	mov dl,1
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807CACC0h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806BB7DFh
	xor r8d,r8d
	xor edx,edx
	call 000000018060F880h
	mov r14,[rsp+80h]
	mov rsi,[rsp+70h]
	movaps xmm6,[rsp+50h]
	mov rdi,[rsp+78h]
	mov rbx,[rsp+88h]
	add rsp,60h
	pop rbp
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x20, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rbp
	004 Move rbp, rsp
	005 ShiftStack -96
	006 Compare [0x184EEB66D], 0
	007 Move rbx, rcx
	008 JumpIfNotEqual {16}
	009 LoadAddress rcx, [0x184C2AFC0]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C7F518]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C2D478]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 Move [0x184EEB66D], 1
	016 Compare [rbx+24], 0
	017 JumpIfEqual {442}
	018 Compare [rbx+311], 0
	019 JumpIfEqual {442}
	020 Move stack:0x78, rdi
	021 Move rcx, typeof(UnityEngine.Object)
	022 Move rdi, [rbx+320]
	023 Compare [rcx+228], 0
	024 JumpIfNotEqual {26}
	025 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	026 Move r8, 0
	027 Move rdx, 0
	028 Move rcx, rdi
	029 Call Object.op_Equality, rcx, rdx, r8
	030 Compare rax, 0
	031 JumpIfNotEqual {441}
	032 Move stack:0x70, rsi
	033 Move stack:0x80, r14
	034 Move stack:0x50, xmm6
	035 Move rcx, [rbx+24]
	036 Compare rcx, 0
	037 JumpIfEqual {447}
	038 Move r8, 0
	039 Move rdx, 0
	040 Call Board.GetSeedTypeInCursor, rcx, rdx
	041 Move rdi, rax
	042 Move rax, [rbx+24]
	043 Compare rax, 0
	044 JumpIfEqual {447}
	045 Move rax, [rax+168]
	046 Compare rax, 0
	047 JumpIfEqual {447}
	048 Move r14, 0
	049 Compare [rax+124], 3
	050 JumpIfNotEqual {73}
	051 Move rax, [rbx+24]
	052 Move rdx, 0
	053 Move rcx, [rax+168]
	054 Move rsi, [rax+120]
	055 Move rcx, [rcx+132]
	056 Call 0x1806BE7D0, rcx, rdx
	057 Compare rsi, 0
	058 JumpIfEqual {447}
	059 Move r8, [0x184C7F518]
	060 Move rdx, rax
	061 Move rcx, rsi
	062 Call 0x182448850, rcx, rdx
	063 Compare rax, 0
	064 JumpIfEqual {73}
	065 Move rcx, [rbx+116]
	066 Compare [rax+116], rcx
	067 JumpIfNotEqual {73}
	068 Move rcx, [rbx+52]
	069 Compare [rax+52], rcx
	070 JumpIfNotEqual {73}
	071 Move xmm2, [0x183C34040]
	072 Goto {229}
	073 Compare rdi, 47
	074 JumpIfNotEqual {97}
	075 Compare [rbx+112], 34
	076 JumpIfNotEqual {97}
	077 Move rcx, [rbx+24]
	078 Compare rcx, 0
	079 JumpIfEqual {447}
	080 Move r8, [rbx+52]
	081 Move r9, 0
	082 Move rdx, [rbx+116]
	083 Call Board.IsValidCobCannonSpot, rcx, rdx, r8
	084 Compare rax, 0
	085 JumpIfNotEqual {169}
	086 Move rcx, [rbx+24]
	087 Compare rcx, 0
	088 JumpIfEqual {447}
	089 Move rdx, [rbx+116]
	090 Move r9, 0
	091 Move r8, [rbx+52]
	092 Subtract rdx, rdx, 1
	093 Call Board.IsValidCobCannonSpot, rcx, rdx, r8
	094 Compare rax, 0
	095 JumpIfNotEqual {169}
	096 Goto {196}
	097 Compare rdi, 40
	098 JumpIfNotEqual {103}
	099 Compare [rbx+112], 7
	100 JumpIfNotEqual {166}
	101 Move rax, 1
	102 Goto {167}
	103 Compare rdi, 44
	104 JumpIfNotEqual {109}
	105 Compare [rbx+112], 39
	106 JumpIfNotEqual {166}
	107 Move rax, 1
	108 Goto {167}
	109 Compare rdi, 41
	110 JumpIfNotEqual {115}
	111 Compare [rbx+112], 1
	112 JumpIfNotEqual {166}
	113 Move rax, 1
	114 Goto {167}
	115 Compare rdi, 46
	116 JumpIfNotEqual {121}
	117 Compare [rbx+112], 21
	118 JumpIfNotEqual {166}
	119 Move rax, 1
	120 Goto {167}
	121 Compare rdi, 47
	122 JumpIfNotEqual {136}
	123 Compare [rbx+112], 34
	124 JumpIfNotEqual {166}
	125 Move rcx, [rbx+24]
	126 Compare rcx, 0
	127 JumpIfEqual {447}
	128 Move r8, [rbx+52]
	129 Move r9, 0
	130 Move rdx, [rbx+116]
	131 Call Board.IsValidCobCannonSpot, rcx, rdx, r8
	132 Compare rax, 0
	133 JumpIfEqual {166}
	134 Move rax, 1
	135 Goto {167}
	136 Compare rdi, 45
	137 JumpIfNotEqual {142}
	138 Compare [rbx+112], 31
	139 JumpIfNotEqual {166}
	140 Move rax, 1
	141 Goto {167}
	142 Compare rdi, 42
	143 JumpIfNotEqual {148}
	144 Compare [rbx+112], 10
	145 JumpIfNotEqual {166}
	146 Move rax, 1
	147 Goto {167}
	148 Compare rdi, 43
	149 JumpIfNotEqual {166}
	150 Compare [rbx+112], 16
	151 JumpIfNotEqual {166}
	152 Move rcx, [rbx+24]
	153 Compare rcx, 0
	154 JumpIfEqual {447}
	155 Move r8, [rbx+52]
	156 Move r9, 6
	157 Move rdx, [rbx+116]
	158 Move stack:0x20, r14
	159 Call Board.GetTopPlantAt, rcx, rdx, r8, r9
	160 Compare rax, 0
	161 JumpIfEqual {164}
	162 Compare [rax+112], rdi
	163 JumpIfEqual {166}
	164 Move rax, 1
	165 Goto {167}
	166 Move rax, 0
	167 Compare rax, 0
	168 JumpIfEqual {194}
	169 Move rcx, [rbx+24]
	170 Compare rcx, 0
	171 JumpIfEqual {447}
	172 Move r8, [rbx+52]
	173 Move r9, rdi
	174 Move rdx, [rbx+116]
	175 Move stack:0x20, r14
	176 Call Board.CanPlantAt, rcx, rdx, r8, r9
	177 Compare rax, 0
	178 JumpIfNotEqual {194}
	179 Move rax, [rbx+24]
	180 Compare rax, 0
	181 JumpIfEqual {447}
	182 Move rcx, typeof(Reloaded.Gameplay.Common)
	183 Move rdi, [rax+492]
	184 Compare [rcx+228], r14
	185 JumpIfNotEqual {187}
	186 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	187 Move r9, 0
	188 LoadAddress rcx, [rbp-32]
	189 Move r8, 90
	190 Move rdx, rdi
	191 Call Common.GetFlashingColor, rcx, rdx, r8
	192 Move xmm2, [rax]
	193 Goto {229}
	194 Compare rdi, 47
	195 JumpIfNotEqual {224}
	196 Compare [rbx+112], 34
	197 JumpIfNotEqual {224}
	198 Move rcx, [rbx+24]
	199 Compare rcx, 0
	200 JumpIfEqual {447}
	201 Move rdx, [rbx+116]
	202 Move r9, 47
	203 Move r8, [rbx+52]
	204 Subtract rdx, rdx, 1
	205 Move stack:0x20, r14
	206 Call Board.CanPlantAt, rcx, rdx, r8, r9
	207 Compare rax, 0
	208 JumpIfNotEqual {224}
	209 Move rax, [rbx+24]
	210 Compare rax, 0
	211 JumpIfEqual {447}
	212 Move rcx, typeof(Reloaded.Gameplay.Common)
	213 Move rdi, [rax+492]
	214 Compare [rcx+228], r14
	215 JumpIfNotEqual {217}
	216 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	217 Move r9, 0
	218 LoadAddress rcx, [rbp-32]
	219 Move r8, 90
	220 Move rdx, rdi
	221 Call Common.GetFlashingColor, rcx, rdx, r8
	222 Move xmm2, [rax]
	223 Goto {229}
	224 Compare [rbx+112], 49
	225 JumpIfEqual {228}
	226 Move xmm2, [0x183C33C90]
	227 Goto {229}
	228 Move xmm2, [0x183C33F80]
	229 Move rcx, [rbx+320]
	230 Move xmm0, xmm2
	231 Move XMM_TEMP.S[0], xmm0.S[1]
	232 Move XMM_TEMP.S[1], xmm0.S[1]
	233 Move XMM_TEMP.S[2], xmm2.S[1]
	234 Move XMM_TEMP.S[3], xmm2.S[1]
	235 Move xmm0, XMM_TEMP
	236 Move xmm1, xmm2
	237 Move XMM_TEMP.S[0], xmm1.S[2]
	238 Move XMM_TEMP.S[1], xmm1.S[2]
	239 Move XMM_TEMP.S[2], xmm2.S[2]
	240 Move XMM_TEMP.S[3], xmm2.S[2]
	241 Move xmm1, XMM_TEMP
	242 Move [rbp-32], xmm2
	243 Move XMM_TEMP.S[0], xmm2.S[3]
	244 Move XMM_TEMP.S[1], xmm2.S[3]
	245 Move XMM_TEMP.S[2], xmm2.S[3]
	246 Move XMM_TEMP.S[3], xmm2.S[3]
	247 Move xmm2, XMM_TEMP
	248 Move [rbp-20], xmm2
	249 Move [rbp-28], xmm0
	250 Move [rbp-24], xmm1
	251 Compare rcx, 0
	252 JumpIfEqual {447}
	253 Move xmm0, [rbp-32]
	254 Move r9, 0
	255 LoadAddress rdx, [rbp-32]
	256 Move r8, 0
	257 Move [rbp-32], xmm0
	258 Call ReloadedController.SetColorOverride, rcx, rdx, r8
	259 Move xmm6, [0x183C33C6C]
	260 Compare [rbx+312], r14
	261 JumpIfNotEqual {350}
	262 Compare [rbx+264], r14
	263 JumpIfGreater {307}
	264 Compare [rbx+260], r14
	265 JumpIfGreater {274}
	266 Move rcx, [rbx+320]
	267 Compare rcx, 0
	268 JumpIfEqual {447}
	269 Move r9, 0
	270 Move r8, 0
	271 Move rdx, 0
	272 Call ReloadedController.SetEnableExtraAdditiveDraw, rcx, rdx, r8
	273 Goto {377}
	274 Compare [rbx+300], 48
	275 Move rdi, 128
	276 Move rcx, typeof(Reloaded.Gameplay.Common)
	277 Move rax, 255
	278 Move rsi, [rbx+260]
	279 JumpIfEqual {281}
	280 Move rdi, rax
	281 Nop 
	282 Compare [rcx+228], r14
	283 JumpIfNotEqual {285}
	284 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	285 LoadAddress rcx, [rsi+rsi*2]
	286 Move r9, 0
	287 Move r8, rdi
	288 Move rdx, 0
	289 Call Common.ClampInt, rcx, rdx, r8, r9
	290 Move rcx, [rbx+320]
	291 Move xmm0, rax
	292 Move xmm1, rax
	293 Move xmm2, rax
	294 Move xmm0, xmm0
	295 Move xmm1, xmm1
	296 Move xmm2, xmm2
	297 Divide xmm0, xmm0, xmm6
	298 Divide xmm1, xmm1, xmm6
	299 Divide xmm2, xmm2, xmm6
	300 Compare rcx, 0
	301 JumpIfEqual {447}
	302 Move [rbp-32], xmm0
	303 Move [rbp-28], xmm1
	304 Move [rbp-24], xmm2
	305 Move [rbp-20], 0x3F800000
	306 Goto {338}
	307 Move rcx, typeof(Reloaded.Gameplay.Common)
	308 Move rdi, [rbx+264]
	309 Compare [rcx+228], r14
	310 JumpIfNotEqual {312}
	311 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	312 Move rax, 0x51EB851F
	313 Move stack:0x30, r14
	314 NotImplemented "imul edi"
	315 Move stack:0x28, 9
	316 Move r9, 0
	317 ShiftRight rdx, 4
	318 Move rcx, 50
	319 Move rax, rdx
	320 Move stack:0x20, 128
	321 ShiftRight rax, 31
	322 Add rdx, rdx, rax
	323 Multiply rax, rdx, 50
	324 Move rdx, 0
	325 Subtract rdi, rdi, rax
	326 Move r8, rdi
	327 Call Common.TodAnimateCurve, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	328 Move rcx, [rbx+320]
	329 Move xmm0, rax
	330 Move xmm0, xmm0
	331 Divide xmm0, xmm0, xmm6
	332 Compare rcx, 0
	333 JumpIfEqual {447}
	334 Move [rbp-20], xmm0
	335 Move [rbp-32], 0x3F800000
	336 Move [rbp-28], 0x3F800000
	337 Move [rbp-24], 0x3F800000
	338 Move r9, 0
	339 LoadAddress rdx, [rbp-32]
	340 Move r8, 0
	341 Call ReloadedController.SetExtraAdditiveColor, rcx, rdx, r8
	342 Move rcx, [rbx+320]
	343 Compare rcx, 0
	344 JumpIfEqual {447}
	345 Move r9, 0
	346 Move r8, 0
	347 Move rdx, 1
	348 Call ReloadedController.SetEnableExtraAdditiveDraw, rcx, rdx, r8
	349 Goto {377}
	350 Move rcx, [rbx+320]
	351 Compare rcx, 0
	352 JumpIfEqual {447}
	353 Move xmm0, [0x183C34030]
	354 LoadAddress rdx, [rbp-32]
	355 Move r9, 0
	356 Move [rbp-32], xmm0
	357 Move r8, 0
	358 Call ReloadedController.SetExtraAdditiveColor, rcx, rdx, r8
	359 Move rcx, [rbx+320]
	360 Compare rcx, 0
	361 JumpIfEqual {447}
	362 Move r9, 0
	363 Move r8, 0
	364 Move rdx, 1
	365 Call ReloadedController.SetEnableExtraAdditiveDraw, rcx, rdx, r8
	366 Compare [rbx+300], 48
	367 JumpIfNotEqual {377}
	368 Move rcx, [rbx+320]
	369 Compare rcx, 0
	370 JumpIfEqual {447}
	371 Move xmm0, [0x183C34020]
	372 LoadAddress rdx, [rbp-32]
	373 Move r9, 0
	374 Move [rbp-32], xmm0
	375 Move r8, 0
	376 Call ReloadedController.SetExtraAdditiveColor, rcx, rdx, r8
	377 Compare [rbx+264], r14
	378 JumpIfGreater {384}
	379 Move rcx, [rbx+320]
	380 Compare rcx, 0
	381 JumpIfEqual {447}
	382 Move rdx, 0
	383 Goto {429}
	384 Move rcx, typeof(Reloaded.Gameplay.Common)
	385 Move rdi, [rbx+264]
	386 Compare [rcx+228], r14
	387 JumpIfNotEqual {389}
	388 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	389 Move rax, 0x51EB851F
	390 Move stack:0x30, r14
	391 NotImplemented "imul edi"
	392 Move stack:0x28, 9
	393 Move r9, 0
	394 ShiftRight rdx, 4
	395 Move rcx, 50
	396 Move rax, rdx
	397 Move stack:0x20, 128
	398 ShiftRight rax, 31
	399 Add rdx, rdx, rax
	400 Multiply rax, rdx, 50
	401 Move rdx, 0
	402 Subtract rdi, rdi, rax
	403 Move r8, rdi
	404 Call Common.TodAnimateCurve, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	405 Move rcx, [rbx+320]
	406 Move xmm0, rax
	407 Move xmm1, rax
	408 Move xmm2, rax
	409 Move xmm0, xmm0
	410 Move xmm1, xmm1
	411 Move xmm2, xmm2
	412 Divide xmm0, xmm0, xmm6
	413 Divide xmm1, xmm1, xmm6
	414 Divide xmm2, xmm2, xmm6
	415 Compare rcx, 0
	416 JumpIfEqual {447}
	417 Move r9, 0
	418 Move [rbp-32], xmm0
	419 Move r8, 0
	420 Move [rbp-28], xmm1
	421 LoadAddress rdx, [rbp-32]
	422 Move [rbp-24], xmm2
	423 Move [rbp-20], 0x3F800000
	424 Call ReloadedController.SetExtraOverlayColor, rcx, rdx, r8
	425 Move rcx, [rbx+320]
	426 Compare rcx, 0
	427 JumpIfEqual {447}
	428 Move rdx, 1
	429 Move r9, 0
	430 Move r8, 0
	431 Call ReloadedController.SetEnableExtraOverlayDraw, rcx, rdx, r8
	432 Move rcx, [rbx+320]
	433 Compare rcx, 0
	434 JumpIfEqual {447}
	435 Move r8, 0
	436 Move rdx, 0
	437 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	438 Move r14, stack:0x80
	439 Move rsi, stack:0x70
	440 Move xmm6, stack:0x50
	441 Move rdi, stack:0x78
	442 Move rbx, stack:0x88
	443 ShiftStack 96
	444 Move rbp, stack:0x0
	445 ShiftStack 8
	446 Return 
	447 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
