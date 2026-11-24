# System.Void Animate()

- 类：`Plant`
- 汇编行数：672

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,20h
	cmp byte ptr [184EEB637h],0
	mov rbx,rcx
	jne short 00000001806AB9E1h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	mov byte ptr [184EEB637h],1
	cmp dword ptr [rbx+70h],2
	mov [rsp+30h],rdi
	je short 00000001806AB9F6h
	cmp dword ptr [rbx+70h],14h
	jne near ptr 00000001806ABA8Ch
	mov rcx,[184C2D478h]
	mov rdi,[rbx+10h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806ABA0Fh
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je short 00000001806ABA8Ch
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806ABEC8h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,2Bh
	je short 00000001806ABA8Ch
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806ABA4Eh
	call 00000001804FEEB0h
	movss xmm0,dword ptr [183C33D94h]
	xor edx,edx
	call 00000001806CBF00h
	subss xmm0,dword ptr [183C33C4Ch]
	xor edx,edx
	movss dword ptr [rbx+10Ch],xmm0
	movss xmm0,dword ptr [183C33D94h]
	call 00000001806CBF00h
	subss xmm0,dword ptr [183C33C4Ch]
	movss dword ptr [rbx+110h],xmm0
	mov rcx,[184C2D478h]
	mov rdi,[rbx+10h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806ABAA5h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je short 00000001806ABACAh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806ABEC8h
	xor edx,edx
	call 00000001807E3010h
	cmp dword ptr [rbx+100h],0
	jle short 00000001806ABAD9h
	dec dword ptr [rbx+100h]
	cmp dword ptr [rbx+104h],0
	jle short 00000001806ABAE8h
	dec dword ptr [rbx+104h]
	cmp dword ptr [rbx+108h],0
	jle short 00000001806ABAF7h
	dec dword ptr [rbx+108h]
	cmp byte ptr [rbx+3Ch],0
	jne near ptr 00000001806ABEB6h
	cmp dword ptr [rbx+70h],3
	je near ptr 00000001806ABDF7h
	cmp dword ptr [rbx+70h],17h
	je near ptr 00000001806ABDF7h
	cmp dword ptr [rbx+70h],24h
	je near ptr 00000001806ABCB9h
	cmp dword ptr [rbx+70h],1Eh
	jne near ptr 00000001806ABE01h
	cmp byte ptr [184EEB668h],0
	jne short 00000001806ABB69h
	lea rcx,[184C7F588h]
	call 00000001804FEB70h
	lea rcx,[184C5E610h]
	call 00000001804FEB70h
	lea rcx,[184C5E458h]
	call 00000001804FEB70h
	lea rcx,[184C5E538h]
	call 00000001804FEB70h
	mov byte ptr [184EEB668h],1
	mov rcx,[rbx+140h]
	mov rdi,[184C7F588h]
	test rcx,rcx
	je near ptr 00000001806ABEC8h
	xor r8d,r8d
	mov rdx,rdi
	call 00000001807C9B90h
	mov rcx,rax
	mov eax,[rbx+90h]
	cdq
	and edx,3
	add eax,edx
	sar eax,2
	cmp [rbx+8Ch],eax
	jl near ptr 00000001806ABC7Bh
	mov eax,[rbx+90h]
	add eax,eax
	cdq
	and edx,3
	add eax,edx
	sar eax,2
	cmp [rbx+8Ch],eax
	jl short 00000001806ABC3Dh
	mov eax,[rbx+90h]
	lea eax,[rax+rax*2]
	cdq
	and edx,3
	add eax,edx
	sar eax,2
	cmp [rbx+8Ch],eax
	jl short 00000001806ABBFFh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806ABEC8h
	xor r9d,r9d
	xor r8d,r8d
	mov rdx,rdi
	call 00000001807CAE90h
	jmp near ptr 00000001806ABE01h
	mov rdx,[184C5E458h]
	xor r8d,r8d
	call 0000000182A27F50h
	test al,al
	je near ptr 00000001806ABE01h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806ABEC8h
	mov r8,[184C5E458h]
	xor r9d,r9d
	mov rdx,rdi
	call 00000001807CAE90h
	jmp near ptr 00000001806ABE01h
	mov rdx,[184C5E538h]
	xor r8d,r8d
	call 0000000182A27F50h
	test al,al
	je near ptr 00000001806ABE01h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806ABEC8h
	mov r8,[184C5E538h]
	xor r9d,r9d
	mov rdx,rdi
	call 00000001807CAE90h
	jmp near ptr 00000001806ABE01h
	mov rdx,[184C5E610h]
	xor r8d,r8d
	call 0000000182A27F50h
	test al,al
	je near ptr 00000001806ABE01h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806ABEC8h
	mov r8,[184C5E610h]
	xor r9d,r9d
	mov rdx,rdi
	call 00000001807CAE90h
	jmp near ptr 00000001806ABE01h
	cmp byte ptr [184EEB672h],0
	jne short 00000001806ABCF9h
	lea rcx,[184C94A90h]
	call 00000001804FEB70h
	lea rcx,[184C5E1C8h]
	call 00000001804FEB70h
	lea rcx,[184C5E0E8h]
	call 00000001804FEB70h
	lea rcx,[184C3FD90h]
	call 00000001804FEB70h
	mov byte ptr [184EEB672h],1
	mov rcx,[rbx+140h]
	mov rdi,[184C94A90h]
	test rcx,rcx
	je near ptr 00000001806ABEC8h
	xor r8d,r8d
	mov rdx,rdi
	call 00000001807C9B90h
	mov r9,rax
	mov eax,55555556h
	imul dword ptr [rbx+90h]
	mov ecx,edx
	shr ecx,1Fh
	add edx,ecx
	cmp [rbx+8Ch],edx
	jl short 00000001806ABD98h
	mov ecx,[rbx+90h]
	mov eax,55555556h
	add ecx,ecx
	imul ecx
	mov eax,edx
	shr eax,1Fh
	add edx,eax
	cmp [rbx+8Ch],edx
	jge near ptr 00000001806ABBDCh
	mov rdx,[184C5E0E8h]
	xor r8d,r8d
	mov rcx,r9
	call 0000000182A27F50h
	test al,al
	je near ptr 00000001806ABE01h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806ABEC8h
	mov r8,[184C5E0E8h]
	xor r9d,r9d
	mov rdx,rdi
	call 00000001807CAE90h
	jmp short 00000001806ABE01h
	mov rdx,[184C5E1C8h]
	xor r8d,r8d
	mov rcx,r9
	call 0000000182A27F50h
	test al,al
	je short 00000001806ABE01h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806ABEC8h
	mov r8,[184C5E1C8h]
	xor r9d,r9d
	mov rdx,rdi
	call 00000001807CAE90h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806ABEC8h
	mov rdx,[184C3FD90h]
	xor r9d,r9d
	mov r8d,0FFFFFFFFh
	call 00000001807C8DB0h
	jmp short 00000001806ABE01h
	xor edx,edx
	mov rcx,rbx
	call 00000001806AB4C0h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B7AC0h
	cmp byte ptr [rbx+134h],0
	mov edx,[rbx+78h]
	mov ecx,edx
	jne short 00000001806ABE60h
	test edx,edx
	jg short 00000001806ABE44h
	add ecx,[rbx+80h]
	mov eax,ecx
	mov byte ptr [rbx+134h],1
	mov [rbx+78h],ecx
	cdq
	idiv dword ptr [rbx+80h]
	mov [rbx+7Ch],eax
	mov rdi,[rsp+30h]
	add rsp,20h
	pop rbx
	ret
	dec ecx
	mov [rbx+78h],ecx
	mov eax,ecx
	cdq
	idiv dword ptr [rbx+80h]
	mov [rbx+7Ch],eax
	mov rdi,[rsp+30h]
	add rsp,20h
	pop rbx
	ret
	mov eax,[rbx+84h]
	imul eax,[rbx+80h]
	dec eax
	cmp edx,eax
	jl short 00000001806ABE9Ah
	sub ecx,[rbx+80h]
	mov eax,ecx
	mov byte ptr [rbx+134h],0
	mov [rbx+78h],ecx
	cdq
	idiv dword ptr [rbx+80h]
	mov [rbx+7Ch],eax
	mov rdi,[rsp+30h]
	add rsp,20h
	pop rbx
	ret
	inc ecx
	mov [rbx+78h],ecx
	mov eax,ecx
	cdq
	idiv dword ptr [rbx+80h]
	mov [rbx+7Ch],eax
	mov rdi,[rsp+30h]
	add rsp,20h
	pop rbx
	ret
	mov rdi,[rsp+30h]
	mov dword ptr [rbx+7Ch],0
	add rsp,20h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -32
	004 Compare [0x184EEB637], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {12}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C2D478]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 Move [0x184EEB637], 1
	012 Compare [rbx+112], 2
	013 Move stack:0x30, rdi
	014 JumpIfEqual {17}
	015 Compare [rbx+112], 20
	016 JumpIfNotEqual {49}
	017 Move rcx, typeof(UnityEngine.Object)
	018 Move rdi, [rbx+16]
	019 Compare [rcx+228], 0
	020 JumpIfNotEqual {22}
	021 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	022 Move r8, 0
	023 Move rdx, 0
	024 Move rcx, rdi
	025 Call Object.op_Inequality, rcx, rdx, r8
	026 Compare rax, 0
	027 JumpIfEqual {49}
	028 Move rcx, [rbx+16]
	029 Compare rcx, 0
	030 JumpIfEqual {361}
	031 Move rdx, 0
	032 Call GameplayActivity.get_GameMode, rcx, rdx
	033 Compare rax, 43
	034 JumpIfEqual {49}
	035 Move rcx, typeof(Reloaded.Gameplay.Common)
	036 Compare [rcx+228], 0
	037 JumpIfNotEqual {39}
	038 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	039 Move xmm0, typeof(T)
	040 Move rdx, 0
	041 Call Common.Rand, xmm0, rdx
	042 Subtract xmm0, xmm0, [0x183C33C4C]
	043 Move rdx, 0
	044 Move [rbx+268], xmm0
	045 Move xmm0, typeof(T)
	046 Call Common.Rand, xmm0, rdx
	047 Subtract xmm0, xmm0, [0x183C33C4C]
	048 Move [rbx+272], xmm0
	049 Move rcx, typeof(UnityEngine.Object)
	050 Move rdi, [rbx+16]
	051 Compare [rcx+228], 0
	052 JumpIfNotEqual {54}
	053 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	054 Move r8, 0
	055 Move rdx, 0
	056 Move rcx, rdi
	057 Call Object.op_Inequality, rcx, rdx, r8
	058 Compare rax, 0
	059 JumpIfEqual {65}
	060 Move rcx, [rbx+16]
	061 Compare rcx, 0
	062 JumpIfEqual {361}
	063 Move rdx, 0
	064 Call GameplayActivity.get_GameMode, rcx, rdx
	065 Compare [rbx+256], 0
	066 JumpIfLessOrEqual {68}
	067 Subtract [rbx+256], [rbx+256], 1
	068 Compare [rbx+260], 0
	069 JumpIfLessOrEqual {71}
	070 Subtract [rbx+260], [rbx+260], 1
	071 Compare [rbx+264], 0
	072 JumpIfLessOrEqual {74}
	073 Subtract [rbx+264], [rbx+264], 1
	074 Compare [rbx+60], 0
	075 JumpIfNotEqual {355}
	076 Compare [rbx+112], 3
	077 JumpIfEqual {264}
	078 Compare [rbx+112], 23
	079 JumpIfEqual {264}
	080 Compare [rbx+112], 36
	081 JumpIfEqual {194}
	082 Compare [rbx+112], 30
	083 JumpIfNotEqual {267}
	084 Compare [0x184EEB668], 0
	085 JumpIfNotEqual {95}
	086 LoadAddress rcx, [0x184C7F588]
	087 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	088 LoadAddress rcx, [0x184C5E610]
	089 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	090 LoadAddress rcx, [0x184C5E458]
	091 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	092 LoadAddress rcx, [0x184C5E538]
	093 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	094 Move [0x184EEB668], 1
	095 Move rcx, [rbx+320]
	096 Move rdi, "Pumpkin_front"
	097 Compare rcx, 0
	098 JumpIfEqual {361}
	099 Move r8, 0
	100 Move rdx, rdi
	101 Call ReloadedController.GetImageOverride, rcx, rdx
	102 Move rcx, rax
	103 Move rax, [rbx+144]
	104 Move TEMP, rax
	105 ShiftRight TEMP, 31
	106 Compare TEMP, 1
	107 JumpIfNotEqual {110}
	108 Move rdx, 0xFFFFFFFF
	109 Goto {111}
	110 Move rdx, 0
	111 Nop 
	112 And rdx, rdx, 3
	113 Add rax, rax, rdx
	114 ShiftRight rax, 2
	115 Compare [rbx+140], rax
	116 JumpIfLess {181}
	117 Move rax, [rbx+144]
	118 Add rax, rax, rax
	119 Move TEMP, rax
	120 ShiftRight TEMP, 31
	121 Compare TEMP, 1
	122 JumpIfNotEqual {125}
	123 Move rdx, 0xFFFFFFFF
	124 Goto {126}
	125 Move rdx, 0
	126 Nop 
	127 And rdx, rdx, 3
	128 Add rax, rax, rdx
	129 ShiftRight rax, 2
	130 Compare [rbx+140], rax
	131 JumpIfLess {168}
	132 Move rax, [rbx+144]
	133 LoadAddress rax, [rax+rax*2]
	134 Move TEMP, rax
	135 ShiftRight TEMP, 31
	136 Compare TEMP, 1
	137 JumpIfNotEqual {140}
	138 Move rdx, 0xFFFFFFFF
	139 Goto {141}
	140 Move rdx, 0
	141 Nop 
	142 And rdx, rdx, 3
	143 Add rax, rax, rdx
	144 ShiftRight rax, 2
	145 Compare [rbx+140], rax
	146 JumpIfLess {155}
	147 Move rcx, [rbx+320]
	148 Compare rcx, 0
	149 JumpIfEqual {361}
	150 Move r9, 0
	151 Move r8, 0
	152 Move rdx, rdi
	153 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	154 Goto {267}
	155 Move rdx, "IMAGE_REANIM_PUMPKIN_DAMAGE1"
	156 Move r8, 0
	157 Call String.op_Inequality, rcx, rdx, r8
	158 Compare rax, 0
	159 JumpIfEqual {267}
	160 Move rcx, [rbx+320]
	161 Compare rcx, 0
	162 JumpIfEqual {361}
	163 Move r8, "IMAGE_REANIM_PUMPKIN_DAMAGE1"
	164 Move r9, 0
	165 Move rdx, rdi
	166 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	167 Goto {267}
	168 Move rdx, "IMAGE_REANIM_PUMPKIN_DAMAGE2"
	169 Move r8, 0
	170 Call String.op_Inequality, rcx, rdx, r8
	171 Compare rax, 0
	172 JumpIfEqual {267}
	173 Move rcx, [rbx+320]
	174 Compare rcx, 0
	175 JumpIfEqual {361}
	176 Move r8, "IMAGE_REANIM_PUMPKIN_DAMAGE2"
	177 Move r9, 0
	178 Move rdx, rdi
	179 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	180 Goto {267}
	181 Move rdx, "IMAGE_REANIM_PUMPKIN_DAMAGE3"
	182 Move r8, 0
	183 Call String.op_Inequality, rcx, rdx, r8
	184 Compare rax, 0
	185 JumpIfEqual {267}
	186 Move rcx, [rbx+320]
	187 Compare rcx, 0
	188 JumpIfEqual {361}
	189 Move r8, "IMAGE_REANIM_PUMPKIN_DAMAGE3"
	190 Move r9, 0
	191 Move rdx, rdi
	192 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	193 Goto {267}
	194 Compare [0x184EEB672], 0
	195 JumpIfNotEqual {205}
	196 LoadAddress rcx, [0x184C94A90]
	197 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	198 LoadAddress rcx, [0x184C5E1C8]
	199 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	200 LoadAddress rcx, [0x184C5E0E8]
	201 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	202 LoadAddress rcx, [0x184C3FD90]
	203 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	204 Move [0x184EEB672], 1
	205 Move rcx, [rbx+320]
	206 Move rdi, "anim_face"
	207 Compare rcx, 0
	208 JumpIfEqual {361}
	209 Move r8, 0
	210 Move rdx, rdi
	211 Call ReloadedController.GetImageOverride, rcx, rdx
	212 Move r9, rax
	213 Move rax, 0x55555556
	214 NotImplemented "imul dword ptr [rbx+90h]"
	215 Move rcx, rdx
	216 ShiftRight rcx, 31
	217 Add rdx, rdx, rcx
	218 Compare [rbx+140], rdx
	219 JumpIfLess {243}
	220 Move rcx, [rbx+144]
	221 Move rax, 0x55555556
	222 Add rcx, rcx, rcx
	223 NotImplemented "imul ecx"
	224 Move rax, rdx
	225 ShiftRight rax, 31
	226 Add rdx, rdx, rax
	227 Compare [rbx+140], rdx
	228 JumpIfGreaterOrEqual {147}
	229 Move rdx, "IMAGE_REANIM_GARLIC_BODY2"
	230 Move r8, 0
	231 Move rcx, r9
	232 Call String.op_Inequality, rcx, rdx, r8
	233 Compare rax, 0
	234 JumpIfEqual {267}
	235 Move rcx, [rbx+320]
	236 Compare rcx, 0
	237 JumpIfEqual {361}
	238 Move r8, "IMAGE_REANIM_GARLIC_BODY2"
	239 Move r9, 0
	240 Move rdx, rdi
	241 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	242 Goto {267}
	243 Move rdx, "IMAGE_REANIM_GARLIC_BODY3"
	244 Move r8, 0
	245 Move rcx, r9
	246 Call String.op_Inequality, rcx, rdx, r8
	247 Compare rax, 0
	248 JumpIfEqual {267}
	249 Move rcx, [rbx+320]
	250 Compare rcx, 0
	251 JumpIfEqual {361}
	252 Move r8, "IMAGE_REANIM_GARLIC_BODY3"
	253 Move r9, 0
	254 Move rdx, rdi
	255 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	256 Move rcx, [rbx+320]
	257 Compare rcx, 0
	258 JumpIfEqual {361}
	259 Move rdx, "Garlic_stem"
	260 Move r9, 0
	261 Move r8, 0xFFFFFFFF
	262 Call ReloadedController.AssignRenderGroupToPrefix, rcx, rdx, r8
	263 Goto {267}
	264 Move rdx, 0
	265 Move rcx, rbx
	266 Call Plant.AnimateNuts, rcx, rdx
	267 Move rdx, 0
	268 Move rcx, rbx
	269 Call Plant.UpdateBlink, rcx, rdx
	270 Compare [rbx+308], 0
	271 Move rdx, [rbx+120]
	272 Move rcx, rdx
	273 JumpIfNotEqual {313}
	274 Compare rdx, 0
	275 JumpIfGreater {295}
	276 Add rcx, rcx, [rbx+128]
	277 Move rax, rcx
	278 Move [rbx+308], 1
	279 Move [rbx+120], rcx
	280 Move TEMP, rax
	281 ShiftRight TEMP, 31
	282 Compare TEMP, 1
	283 JumpIfNotEqual {286}
	284 Move rdx, 0xFFFFFFFF
	285 Goto {287}
	286 Move rdx, 0
	287 Nop 
	288 NotImplemented "idiv dword ptr [rbx+80h]"
	289 Move [rbx+124], rax
	290 Move rdi, stack:0x30
	291 ShiftStack 32
	292 Move rbx, stack:0x0
	293 ShiftStack 8
	294 Return 
	295 Subtract rcx, rcx, 1
	296 Move [rbx+120], rcx
	297 Move rax, rcx
	298 Move TEMP, rax
	299 ShiftRight TEMP, 31
	300 Compare TEMP, 1
	301 JumpIfNotEqual {304}
	302 Move rdx, 0xFFFFFFFF
	303 Goto {305}
	304 Move rdx, 0
	305 Nop 
	306 NotImplemented "idiv dword ptr [rbx+80h]"
	307 Move [rbx+124], rax
	308 Move rdi, stack:0x30
	309 ShiftStack 32
	310 Move rbx, stack:0x0
	311 ShiftStack 8
	312 Return 
	313 Move rax, [rbx+132]
	314 Multiply rax, rax, [rbx+128]
	315 Subtract rax, rax, 1
	316 Compare rdx, rax
	317 JumpIfLess {337}
	318 Subtract rcx, rcx, [rbx+128]
	319 Move rax, rcx
	320 Move [rbx+308], 0
	321 Move [rbx+120], rcx
	322 Move TEMP, rax
	323 ShiftRight TEMP, 31
	324 Compare TEMP, 1
	325 JumpIfNotEqual {328}
	326 Move rdx, 0xFFFFFFFF
	327 Goto {329}
	328 Move rdx, 0
	329 Nop 
	330 NotImplemented "idiv dword ptr [rbx+80h]"
	331 Move [rbx+124], rax
	332 Move rdi, stack:0x30
	333 ShiftStack 32
	334 Move rbx, stack:0x0
	335 ShiftStack 8
	336 Return 
	337 Add rcx, rcx, 1
	338 Move [rbx+120], rcx
	339 Move rax, rcx
	340 Move TEMP, rax
	341 ShiftRight TEMP, 31
	342 Compare TEMP, 1
	343 JumpIfNotEqual {346}
	344 Move rdx, 0xFFFFFFFF
	345 Goto {347}
	346 Move rdx, 0
	347 Nop 
	348 NotImplemented "idiv dword ptr [rbx+80h]"
	349 Move [rbx+124], rax
	350 Move rdi, stack:0x30
	351 ShiftStack 32
	352 Move rbx, stack:0x0
	353 ShiftStack 8
	354 Return 
	355 Move rdi, stack:0x30
	356 Move [rbx+124], 0
	357 ShiftStack 32
	358 Move rbx, stack:0x0
	359 ShiftStack 8
	360 Return 
	361 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
