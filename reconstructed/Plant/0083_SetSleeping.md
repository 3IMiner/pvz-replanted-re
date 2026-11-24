# System.Void SetSleeping(System.Boolean theIsAsleep)

- 类：`Plant`
- 汇编行数：401

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	push rdi
	sub rsp,50h
	cmp byte ptr [184EEB65Fh],0
	movzx edi,dl
	mov rbx,rcx
	jne short 00000001806B5780h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184CAC9F0h]
	call 00000001804FEB70h
	lea rcx,[184C905A8h]
	call 00000001804FEB70h
	lea rcx,[184CAC920h]
	call 00000001804FEB70h
	lea rcx,[184C84248h]
	call 00000001804FEB70h
	lea rcx,[184C844D0h]
	call 00000001804FEB70h
	lea rcx,[184C95FA8h]
	call 00000001804FEB70h
	lea rcx,[184C98670h]
	call 00000001804FEB70h
	mov byte ptr [184EEB65Fh],1
	cmp [rbx+136h],dil
	je near ptr 00000001806B5922h
	cmp dword ptr [rbx+70h],11h
	jne short 00000001806B57BAh
	cmp dword ptr [rbx+88h],5
	je near ptr 00000001806B5922h
	cmp dword ptr [rbx+88h],6
	je near ptr 00000001806B5922h
	cmp dword ptr [rbx+88h],7
	je near ptr 00000001806B5922h
	cmp byte ptr [rbx+3Ch],0
	jne near ptr 00000001806B5922h
	cmp dword ptr [rbx+128h],2
	je near ptr 00000001806B5922h
	cmp byte ptr [rbx+135h],0
	jne near ptr 00000001806B5922h
	movaps [rsp+40h],xmm6
	movaps [rsp+30h],xmm7
	mov [rbx+136h],dil
	test dil,dil
	jne near ptr 00000001806B592Dh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B5A7Ch
	mov edx,[rbx+0F8h]
	xor r8d,r8d
	call 00000001807E14A0h
	xor ecx,ecx
	call 000000018063CD70h
	mov [rbx+0F8h],eax
	xor edx,edx
	mov rcx,rbx
	call 00000001806B21F0h
	test al,al
	jne short 00000001806B584Dh
	cmp dword ptr [rbx+70h],9
	jne short 00000001806B584Dh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B5A7Ch
	mov rdx,[184CAC920h]
	jmp short 00000001806B588Ah
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B5A7Ch
	mov rdx,[184C95FA8h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8940h
	test al,al
	je short 00000001806B5895h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B5A7Ch
	mov rdx,[184C905A8h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8230h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B5A7Ch
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78A0h
	movss xmm1,dword ptr [183C33D94h]
	comiss xmm1,xmm0
	jbe short 00000001806B5918h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B21F0h
	test al,al
	je short 00000001806B5918h
	mov rcx,[184C2AFC0h]
	mov rbx,[rbx+140h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B58E6h
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DB8h]
	xor r8d,r8d
	movss xmm0,dword ptr [183C33DACh]
	call 00000001806CBD40h
	test rbx,rbx
	je near ptr 00000001806B5A7Ch
	xor r9d,r9d
	xor r8d,r8d
	movaps xmm1,xmm0
	mov rcx,rbx
	call 00000001807C8740h
	movaps xmm6,[rsp+40h]
	movaps xmm7,[rsp+30h]
	mov rbx,[rsp+60h]
	add rsp,50h
	pop rdi
	ret
	cmp dword ptr [rbx+70h],0Ah
	movss xmm7,dword ptr [rbx+20h]
	movss xmm6,dword ptr [rbx+24h]
	addss xmm7,dword ptr [183C33DC8h]
	addss xmm6,dword ptr [183C33DC4h]
	je short 00000001806B596Dh
	cmp dword ptr [rbx+70h],0Dh
	je short 00000001806B5963h
	cmp dword ptr [rbx+70h],2Ah
	jne short 00000001806B5975h
	addss xmm6,dword ptr [183C3400Ch]
	jmp short 00000001806B5975h
	addss xmm6,dword ptr [183C33F48h]
	jmp short 00000001806B5975h
	addss xmm7,dword ptr [183C33DB4h]
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B5A7Ch
	mov rdx,[184C844D0h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8230h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B5A7Ch
	mov r9d,[rbx+38h]
	movaps xmm2,xmm6
	add r9d,2
	mov qword ptr [rsp+28h],0
	movaps xmm1,xmm7
	mov dword ptr [rsp+20h],44h
	call 00000001807D96D0h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B5A7Ch
	xor r8d,r8d
	mov rdx,rax
	call 00000001807E13A0h
	xor edx,edx
	mov [rbx+0F8h],eax
	mov rcx,rbx
	call 00000001806B21F0h
	test al,al
	jne short 00000001806B5A0Fh
	cmp dword ptr [rbx+70h],9
	jne short 00000001806B5A0Fh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B5A7Ch
	mov rdx,[184CAC9F0h]
	jmp short 00000001806B5A59h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B5A7Ch
	mov rdx,[184C98670h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8940h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B5A7Ch
	test al,al
	jne short 00000001806B5A52h
	movss xmm1,dword ptr [183C33C4Ch]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8740h
	jmp short 00000001806B5A64h
	mov rdx,[184C84248h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8230h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B5A7Ch
	xor edx,edx
	call 00000001807C7650h
	jmp near ptr 00000001806B5918h
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -80
	005 Compare [0x184EEB65F], 0
	006 Move rdi, rdx
	007 Move rbx, rcx
	008 JumpIfNotEqual {26}
	009 LoadAddress rcx, [0x184C2AFC0]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184CAC9F0]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C905A8]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184CAC920]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C84248]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 LoadAddress rcx, [0x184C844D0]
	020 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	021 LoadAddress rcx, [0x184C95FA8]
	022 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	023 LoadAddress rcx, [0x184C98670]
	024 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	025 Move [0x184EEB65F], 1
	026 Compare [rbx+310], rdi
	027 JumpIfEqual {116}
	028 Compare [rbx+112], 17
	029 JumpIfNotEqual {36}
	030 Compare [rbx+136], 5
	031 JumpIfEqual {116}
	032 Compare [rbx+136], 6
	033 JumpIfEqual {116}
	034 Compare [rbx+136], 7
	035 JumpIfEqual {116}
	036 Compare [rbx+60], 0
	037 JumpIfNotEqual {116}
	038 Compare [rbx+296], 2
	039 JumpIfEqual {116}
	040 Compare [rbx+309], 0
	041 JumpIfNotEqual {116}
	042 Move stack:0x40, xmm6
	043 Move stack:0x30, xmm7
	044 Move [rbx+310], rdi
	045 Compare rdi, 0
	046 JumpIfNotEqual {121}
	047 Move rcx, [rbx+16]
	048 Compare rcx, 0
	049 JumpIfEqual {199}
	050 Move rdx, [rbx+248]
	051 Move r8, 0
	052 Call GameplayActivity.RemoveReanimation, rcx, rdx
	053 Move rcx, 0
	054 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	055 Move [rbx+248], rax
	056 Move rdx, 0
	057 Move rcx, rbx
	058 Call Plant.IsInPlay, rcx, rdx
	059 Compare rax, 0
	060 JumpIfNotEqual {68}
	061 Compare [rbx+112], 9
	062 JumpIfNotEqual {68}
	063 Move rcx, [rbx+320]
	064 Compare rcx, 0
	065 JumpIfEqual {199}
	066 Move rdx, "bigidle"
	067 Goto {81}
	068 Move rcx, [rbx+320]
	069 Compare rcx, 0
	070 JumpIfEqual {199}
	071 Move rdx, "anim_idle"
	072 Move r9, 0
	073 Move r8, 0
	074 Call ReloadedCharacterController.TrackExistsOnTrack, rcx, rdx, r8
	075 Compare rax, 0
	076 JumpIfEqual {84}
	077 Move rcx, [rbx+320]
	078 Compare rcx, 0
	079 JumpIfEqual {199}
	080 Move rdx, "idle"
	081 Move r9, 0
	082 Move r8, 0
	083 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, r8
	084 Move rcx, [rbx+320]
	085 Compare rcx, 0
	086 JumpIfEqual {199}
	087 Move r8, 0
	088 Move rdx, 0
	089 Call ReloadedCharacterController.GetAnimationRateOnTrack, rcx, rdx
	090 Move xmm1, typeof(T)
	091 Compare xmm1, xmm0
	092 JumpIfLessOrEqual {114}
	093 Move rdx, 0
	094 Move rcx, rbx
	095 Call Plant.IsInPlay, rcx, rdx
	096 Compare rax, 0
	097 JumpIfEqual {114}
	098 Move rcx, typeof(Reloaded.Gameplay.Common)
	099 Move rbx, [rbx+320]
	100 Compare [rcx+228], 0
	101 JumpIfNotEqual {103}
	102 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	103 Move xmm1, [0x183C33DB8]
	104 Move r8, 0
	105 Move xmm0, [0x183C33DAC]
	106 Call Common.RandRangeFloat, xmm0, xmm1, r8
	107 Compare rbx, 0
	108 JumpIfEqual {199}
	109 Move r9, 0
	110 Move r8, 0
	111 Move xmm1, xmm0
	112 Move rcx, rbx
	113 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	114 Move xmm6, stack:0x40
	115 Move xmm7, stack:0x30
	116 Move rbx, stack:0x60
	117 ShiftStack 80
	118 Move rdi, stack:0x0
	119 ShiftStack 8
	120 Return 
	121 Compare [rbx+112], 10
	122 Move xmm7, [rbx+32]
	123 Move xmm6, [rbx+36]
	124 Add xmm7, xmm7, [0x183C33DC8]
	125 Add xmm6, xmm6, [0x183C33DC4]
	126 JumpIfEqual {135}
	127 Compare [rbx+112], 13
	128 JumpIfEqual {133}
	129 Compare [rbx+112], 42
	130 JumpIfNotEqual {136}
	131 Add xmm6, xmm6, [0x183C3400C]
	132 Goto {136}
	133 Add xmm6, xmm6, [0x183C33F48]
	134 Goto {136}
	135 Add xmm7, xmm7, [0x183C33DB4]
	136 Move rcx, [rbx+320]
	137 Compare rcx, 0
	138 JumpIfEqual {199}
	139 Move rdx, "sleeping"
	140 Move r9, 0
	141 Move r8, 0
	142 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, r8
	143 Move rcx, [rbx+16]
	144 Compare rcx, 0
	145 JumpIfEqual {199}
	146 Move r9, [rbx+56]
	147 Move xmm2, xmm6
	148 Add r9, r9, 2
	149 Move stack:0x28, 0
	150 Move xmm1, xmm7
	151 Move stack:0x20, 68
	152 Call GameplayActivity.AddReanimation, rcx, xmm1, r8, r9, stack:0x0
	153 Move rcx, [rbx+16]
	154 Compare rcx, 0
	155 JumpIfEqual {199}
	156 Move r8, 0
	157 Move rdx, rax
	158 Call GameplayActivity.ReanimationGetID, rcx, rdx
	159 Move rdx, 0
	160 Move [rbx+248], rax
	161 Move rcx, rbx
	162 Call Plant.IsInPlay, rcx, rdx
	163 Compare rax, 0
	164 JumpIfNotEqual {172}
	165 Compare [rbx+112], 9
	166 JumpIfNotEqual {172}
	167 Move rcx, [rbx+320]
	168 Compare rcx, 0
	169 JumpIfEqual {199}
	170 Move rdx, "bigsleep"
	171 Goto {190}
	172 Move rcx, [rbx+320]
	173 Compare rcx, 0
	174 JumpIfEqual {199}
	175 Move rdx, "anim_sleep"
	176 Move r9, 0
	177 Move r8, 0
	178 Call ReloadedCharacterController.TrackExistsOnTrack, rcx, rdx, r8
	179 Move rcx, [rbx+320]
	180 Compare rcx, 0
	181 JumpIfEqual {199}
	182 Compare rax, 0
	183 JumpIfNotEqual {189}
	184 Move xmm1, [0x183C33C4C]
	185 Move r9, 0
	186 Move r8, 0
	187 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	188 Goto {193}
	189 Move rdx, "sleep"
	190 Move r9, 0
	191 Move r8, 0
	192 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, r8
	193 Move rcx, [rbx+320]
	194 Compare rcx, 0
	195 JumpIfEqual {199}
	196 Move rdx, 0
	197 Call ReloadedCharacterController.DisableBlink, rcx, rdx
	198 Goto {114}
	199 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
