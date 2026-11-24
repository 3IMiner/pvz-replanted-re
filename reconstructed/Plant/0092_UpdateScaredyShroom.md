# System.Void UpdateScaredyShroom()

- 类：`Plant`
- 汇编行数：531

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,0A0h
	cmp byte ptr [184EEB662h],0
	mov rbx,rcx
	jne short 00000001806BBF54h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	lea rcx,[184C98160h]
	call 00000001804FEB70h
	lea rcx,[184C95150h]
	call 00000001804FEB70h
	lea rcx,[184C98238h]
	call 00000001804FEB70h
	mov byte ptr [184EEB662h],1
	cmp dword ptr [rbx+0DCh],0
	jg near ptr 00000001806BC40Eh
	mov [rsp+0B8h],rsi
	mov [rsp+98h],r14
	mov [rsp+90h],r15
	mov [rsp+0B0h],rbp
	mov [rsp+0C0h],rdi
	movaps [rsp+80h],xmm6
	movaps [rsp+70h],xmm7
	movaps [rsp+60h],xmm8
	movaps [rsp+50h],xmm9
	mov rax,[rbx+18h]
	xor r15d,r15d
	xor r14b,r14b
	mov esi,r15d
	mov edx,r15d
	test rax,rax
	je near ptr 00000001806BC417h
	movss xmm9,dword ptr [183C33DBCh]
	nop dword ptr [rax]
	nop dword ptr [rax+rax]
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806BC417h
	cmp edx,[rcx+28h]
	jge near ptr 00000001806BC0C0h
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806BC417h
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806BC417h
	mov r8,[184C81528h]
	mov edx,esi
	call 0000000182449330h
	mov rdi,rax
	test rax,rax
	je near ptr 00000001806BC417h
	xor r8d,r8d
	lea rcx,[rsp+40h]
	mov rdx,rax
	call 00000001806F2D70h
	movups xmm8,[rax]
	mov eax,[rdi+34h]
	mov ebp,r15d
	sub eax,[rbx+34h]
	cmp dword ptr [rdi+70h],19h
	cmovne ebp,eax
	cmp [rdi+110h],r14b
	jne short 00000001806BC0A7h
	xor edx,edx
	mov rcx,rdi
	call 00000001806F3600h
	test al,al
	jne short 00000001806BC0A7h
	lea eax,[rbp+1]
	cmp eax,2
	ja short 00000001806BC0A7h
	mov rcx,[184C2AFC0h]
	movss xmm7,dword ptr [rbx+20h]
	movss xmm6,dword ptr [rbx+24h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806BC07Ch
	call 00000001804FEEB0h
	addss xmm6,xmm9
	movdqa [rsp+30h],xmm8
	lea r9,[rsp+30h]
	mov [rsp+20h],r15
	mov r8d,78h
	movaps xmm0,xmm7
	movaps xmm1,xmm6
	call 00000001806CB910h
	test al,al
	jne short 00000001806BC0BDh
	mov rax,[rbx+18h]
	inc esi
	mov edx,esi
	test rax,rax
	je near ptr 00000001806BC417h
	jmp near ptr 00000001806BBFD0h
	mov r14b,1
	cmp dword ptr [rbx+88h],1
	je near ptr 00000001806BC2F3h
	cmp dword ptr [rbx+88h],14h
	je near ptr 00000001806BC21Ah
	cmp dword ptr [rbx+88h],15h
	je near ptr 00000001806BC199h
	cmp dword ptr [rbx+88h],16h
	jne near ptr 00000001806BC3B8h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BC417h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806BC3B8h
	mov dword ptr [rbx+88h],1
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806BC135h
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DB8h]
	xor r8d,r8d
	movss xmm0,dword ptr [183C33DACh]
	call 00000001806CBD40h
	xor r8d,r8d
	movaps xmm1,xmm0
	mov rcx,rbx
	call 00000001806B4C50h
	mov rdi,[rbx+140h]
	test rdi,rdi
	je near ptr 00000001806BC417h
	mov rdi,[rdi+158h]
	xor edx,edx
	mov ecx,2
	call 0000000180727400h
	test rdi,rdi
	je near ptr 00000001806BC417h
	xor r8d,r8d
	mov edx,eax
	mov rcx,rdi
	call 0000000180722400h
	jmp near ptr 00000001806BC3B8h
	test r14b,r14b
	jne near ptr 00000001806BC3B8h
	mov dword ptr [rbx+88h],16h
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r15d
	jne short 00000001806BC1C1h
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DB4h]
	xor r8d,r8d
	movss xmm0,dword ptr [183C33ED8h]
	call 00000001806CBD40h
	mov rcx,[rbx+140h]
	movaps xmm6,xmm0
	test rcx,rcx
	je near ptr 00000001806BC417h
	mov rdx,[184C95150h]
	movaps xmm3,xmm0
	mov [rsp+28h],r15
	mov r8d,2
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov rdi,[184C95150h]
	jmp near ptr 00000001806BC347h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BC417h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806BC3B8h
	cmp [184EEB658h],r15b
	mov dword ptr [rbx+88h],15h
	mov rdi,[184C98238h]
	jne short 00000001806BC275h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806BC417h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BC417h
	mov [rsp+28h],r15
	xorps xmm3,xmm3
	xor r8d,r8d
	mov [rsp+20h],r15d
	mov rdx,rax
	call 00000001807C8270h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BC417h
	movss xmm3,dword ptr [183C33DACh]
	mov r8d,2
	mov rdx,[184C98238h]
	mov [rsp+28h],r15
	mov [rsp+20h],r15d
	jmp near ptr 00000001806BC3B3h
	test r14b,r14b
	je near ptr 00000001806BC3B8h
	mov rcx,[rbx+140h]
	mov dword ptr [rbx+88h],14h
	test rcx,rcx
	je near ptr 00000001806BC417h
	movss xmm6,dword ptr [183C33DACh]
	mov r8d,2
	mov rdx,[184C98160h]
	movaps xmm3,xmm6
	mov [rsp+28h],r15
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov rdi,[184C98160h]
	cmp [184EEB658h],r15b
	jne short 00000001806BC36Fh
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806BC417h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806BC417h
	mov [rsp+28h],r15
	movaps xmm3,xmm6
	mov dword ptr [rsp+20h],3
	xor r8d,r8d
	mov rdx,rax
	call 00000001807C8270h
	cmp dword ptr [rbx+88h],1
	je short 00000001806BC3CDh
	mov eax,[rbx+0A8h]
	mov [rbx+0A4h],eax
	movaps xmm8,[rsp+60h]
	movaps xmm7,[rsp+70h]
	movaps xmm6,[rsp+80h]
	mov rbp,[rsp+0B0h]
	mov rdi,[rsp+0C0h]
	movaps xmm9,[rsp+50h]
	mov rsi,[rsp+0B8h]
	mov r14,[rsp+98h]
	mov r15,[rsp+90h]
	add rsp,0A0h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -160
	004 Compare [0x184EEB662], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {20}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C81450]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C81528]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C98160]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184C95150]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C98238]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 Move [0x184EEB662], 1
	020 Compare [rbx+220], 0
	021 JumpIfGreater {261}
	022 Move stack:0xB8, rsi
	023 Move stack:0x98, r14
	024 Move stack:0x90, r15
	025 Move stack:0xB0, rbp
	026 Move stack:0xC0, rdi
	027 Move stack:0x80, xmm6
	028 Move stack:0x70, xmm7
	029 Move stack:0x60, xmm8
	030 Move stack:0x50, xmm9
	031 Move rax, [rbx+24]
	032 Move r15, 0
	033 Move r14, 0
	034 Move rsi, r15
	035 Move rdx, r15
	036 Compare rax, 0
	037 JumpIfEqual {265}
	038 Move xmm9, [0x183C33DBC]
	039 Nop 
	040 Nop 
	041 Move rcx, [rax+112]
	042 Compare rcx, 0
	043 JumpIfEqual {265}
	044 Compare rdx, [rcx+40]
	045 JumpIfGreaterOrEqual {103}
	046 Move rax, [rbx+24]
	047 Compare rax, 0
	048 JumpIfEqual {265}
	049 Move rcx, [rax+112]
	050 Compare rcx, 0
	051 JumpIfEqual {265}
	052 Move r8, [0x184C81528]
	053 Move rdx, rsi
	054 Call 0x182449330, rcx, rdx
	055 Move rdi, rax
	056 Compare rax, 0
	057 JumpIfEqual {265}
	058 Move r8, 0
	059 LoadAddress rcx, stack:0x40
	060 Move rdx, rax
	061 Call Zombie.GetZombieRect, rcx, rdx
	062 Move xmm8, [rax]
	063 Move rax, [rdi+52]
	064 Move rbp, r15
	065 Subtract rax, rax, [rbx+52]
	066 Compare [rdi+112], 25
	067 JumpIfEqual {69}
	068 Move rbp, rax
	069 Nop 
	070 Compare [rdi+272], r14
	071 JumpIfNotEqual {96}
	072 Move rdx, 0
	073 Move rcx, rdi
	074 Call Zombie.IsDeadOrDying, rcx, rdx
	075 Compare rax, 0
	076 JumpIfNotEqual {96}
	077 LoadAddress rax, [rbp+1]
	078 Compare rax, 2
	079 JumpIfGreater {96}
	080 Move rcx, typeof(Reloaded.Gameplay.Common)
	081 Move xmm7, [rbx+32]
	082 Move xmm6, [rbx+36]
	083 Compare [rcx+228], r15
	084 JumpIfNotEqual {86}
	085 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	086 Add xmm6, xmm6, xmm9
	087 Move stack:0x30, xmm8
	088 LoadAddress r9, stack:0x30
	089 Move stack:0x20, r15
	090 Move r8, 120
	091 Move xmm0, xmm7
	092 Move xmm1, xmm6
	093 Call Common.GetCircleRectOverlap, xmm0, xmm1, r8, r9, stack:0x0
	094 Compare rax, 0
	095 JumpIfNotEqual {102}
	096 Move rax, [rbx+24]
	097 Add rsi, rsi, 1
	098 Move rdx, rsi
	099 Compare rax, 0
	100 JumpIfEqual {265}
	101 Goto {41}
	102 Move r14, 1
	103 Compare [rbx+136], 1
	104 JumpIfEqual {211}
	105 Compare [rbx+136], 20
	106 JumpIfEqual {169}
	107 Compare [rbx+136], 21
	108 JumpIfEqual {146}
	109 Compare [rbx+136], 22
	110 JumpIfNotEqual {248}
	111 Move rcx, [rbx+320]
	112 Compare rcx, 0
	113 JumpIfEqual {265}
	114 Move r8, 0
	115 Move rdx, 0
	116 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	117 Compare rax, 0
	118 JumpIfLessOrEqual {248}
	119 Move [rbx+136], 1
	120 Move rcx, typeof(Reloaded.Gameplay.Common)
	121 Compare [rcx+228], r15
	122 JumpIfNotEqual {124}
	123 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	124 Move xmm1, [0x183C33DB8]
	125 Move r8, 0
	126 Move xmm0, [0x183C33DAC]
	127 Call Common.RandRangeFloat, xmm0, xmm1, r8
	128 Move r8, 0
	129 Move xmm1, xmm0
	130 Move rcx, rbx
	131 Call Plant.PlayIdleAnim, rcx, rdx
	132 Move rdi, [rbx+320]
	133 Compare rdi, 0
	134 JumpIfEqual {265}
	135 Move rdi, [rdi+344]
	136 Move rdx, 0
	137 Move rcx, 2
	138 Call CharacterAnimationExtensions.ToCharacterTrack, rcx, rdx
	139 Compare rdi, 0
	140 JumpIfEqual {265}
	141 Move r8, 0
	142 Move rdx, rax
	143 Move rcx, rdi
	144 Call CharacterAnimationController.ClearTrackEntry, rcx, rdx
	145 Goto {248}
	146 Compare r14, 0
	147 JumpIfNotEqual {248}
	148 Move [rbx+136], 22
	149 Move rcx, typeof(Reloaded.Gameplay.Common)
	150 Compare [rcx+228], r15
	151 JumpIfNotEqual {153}
	152 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	153 Move xmm1, [0x183C33DB4]
	154 Move r8, 0
	155 Move xmm0, [0x183C33ED8]
	156 Call Common.RandRangeFloat, xmm0, xmm1, r8
	157 Move rcx, [rbx+320]
	158 Move xmm6, xmm0
	159 Compare rcx, 0
	160 JumpIfEqual {265}
	161 Move rdx, "anim_grow"
	162 Move xmm3, xmm0
	163 Move stack:0x28, r15
	164 Move r8, 2
	165 Move stack:0x20, 3
	166 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	167 Move rdi, "anim_grow"
	168 Goto {225}
	169 Move rcx, [rbx+320]
	170 Compare rcx, 0
	171 JumpIfEqual {265}
	172 Move r8, 0
	173 Move rdx, 0
	174 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	175 Compare rax, 0
	176 JumpIfLessOrEqual {248}
	177 Compare [0x184EEB658], r15
	178 Move [rbx+136], 21
	179 Move rdi, "anim_scaredidle"
	180 JumpIfNotEqual {186}
	181 LoadAddress rcx, [0x184C92A80]
	182 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	183 LoadAddress rcx, [0x184C911F8]
	184 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	185 Move [0x184EEB658], 1
	186 Compare rdi, 0
	187 JumpIfEqual {265}
	188 Move r8, ""
	189 Move r9, 0
	190 Move rdx, "anim_"
	191 Move rcx, rdi
	192 Call String.Replace, rcx, rdx, r8
	193 Move rcx, [rbx+320]
	194 Compare rcx, 0
	195 JumpIfEqual {265}
	196 Move stack:0x28, r15
	197 Move xmm3, 0
	198 Move r8, 0
	199 Move stack:0x20, r15
	200 Move rdx, rax
	201 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	202 Move rcx, [rbx+320]
	203 Compare rcx, 0
	204 JumpIfEqual {265}
	205 Move xmm3, [0x183C33DAC]
	206 Move r8, 2
	207 Move rdx, "anim_scaredidle"
	208 Move stack:0x28, r15
	209 Move stack:0x20, r15
	210 Goto {247}
	211 Compare r14, 0
	212 JumpIfEqual {248}
	213 Move rcx, [rbx+320]
	214 Move [rbx+136], 20
	215 Compare rcx, 0
	216 JumpIfEqual {265}
	217 Move xmm6, [0x183C33DAC]
	218 Move r8, 2
	219 Move rdx, "anim_scared"
	220 Move xmm3, xmm6
	221 Move stack:0x28, r15
	222 Move stack:0x20, 3
	223 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	224 Move rdi, "anim_scared"
	225 Compare [0x184EEB658], r15
	226 JumpIfNotEqual {232}
	227 LoadAddress rcx, [0x184C92A80]
	228 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	229 LoadAddress rcx, [0x184C911F8]
	230 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	231 Move [0x184EEB658], 1
	232 Compare rdi, 0
	233 JumpIfEqual {265}
	234 Move r8, ""
	235 Move r9, 0
	236 Move rdx, "anim_"
	237 Move rcx, rdi
	238 Call String.Replace, rcx, rdx, r8
	239 Move rcx, [rbx+320]
	240 Compare rcx, 0
	241 JumpIfEqual {265}
	242 Move stack:0x28, r15
	243 Move xmm3, xmm6
	244 Move stack:0x20, 3
	245 Move r8, 0
	246 Move rdx, rax
	247 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	248 Compare [rbx+136], 1
	249 JumpIfEqual {252}
	250 Move rax, [rbx+168]
	251 Move [rbx+164], rax
	252 Move xmm8, stack:0x60
	253 Move xmm7, stack:0x70
	254 Move xmm6, stack:0x80
	255 Move rbp, stack:0xB0
	256 Move rdi, stack:0xC0
	257 Move xmm9, stack:0x50
	258 Move rsi, stack:0xB8
	259 Move r14, stack:0x98
	260 Move r15, stack:0x90
	261 ShiftStack 160
	262 Move rbx, stack:0x0
	263 ShiftStack 8
	264 Return 
	265 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
