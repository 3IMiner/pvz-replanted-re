# System.Void UpdateChomper()

- 类：`Plant`
- 汇编行数：486

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,30h
	cmp byte ptr [184EEB655h],0
	mov rbx,rcx
	jne short 00000001806B87A9h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C932A8h]
	call 00000001804FEB70h
	lea rcx,[184C39168h]
	call 00000001804FEB70h
	lea rcx,[184CADDD0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB655h],1
	cmp dword ptr [rbx+88h],1
	mov [rsp+48h],rsi
	mov [rsp+50h],rdi
	je near ptr 00000001806B8AD1h
	cmp dword ptr [rbx+88h],0Ah
	je near ptr 00000001806B896Ah
	cmp dword ptr [rbx+88h],0Bh
	je near ptr 00000001806B88BEh
	cmp dword ptr [rbx+88h],0Dh
	je short 00000001806B8840h
	cmp dword ptr [rbx+88h],0Eh
	je short 00000001806B87F5h
	cmp dword ptr [rbx+88h],0Ch
	jne short 00000001806B8830h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B8B82h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle short 00000001806B8830h
	movss xmm1,dword ptr [183C33DB4h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B4C50h
	mov dword ptr [rbx+88h],1
	mov rdi,[rsp+50h]
	mov rsi,[rsp+48h]
	add rsp,30h
	pop rbx
	ret
	cmp dword ptr [rbx+0A0h],0
	jne short 00000001806B8830h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B8B82h
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B8B82h
	movss xmm3,dword ptr [183C33DB4h]
	xor r8d,r8d
	mov rdx,[184C932A8h]
	mov qword ptr [rsp+28h],0
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov dword ptr [rbx+88h],0Eh
	mov rdi,[rsp+50h]
	mov rsi,[rsp+48h]
	add rsp,30h
	pop rbx
	ret
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B8B82h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B8830h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B8B82h
	movss xmm3,dword ptr [183C33DB8h]
	xor r8d,r8d
	mov rdx,[184C39168h]
	mov qword ptr [rsp+20h],0
	call 00000001807C8210h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B8B82h
	xor edx,edx
	call 00000001807DF5D0h
	test al,al
	je short 00000001806B8946h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B8B82h
	xor r9d,r9d
	xor r8d,r8d
	xorps xmm1,xmm1
	call 00000001807C8740h
	mov dword ptr [rbx+88h],0Dh
	mov dword ptr [rbx+0A0h],0FA0h
	mov rdi,[rsp+50h]
	mov rsi,[rsp+48h]
	add rsp,30h
	pop rbx
	ret
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806B8830h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B8B82h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B8B82h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,3Dh
	mov [rsp+40h],rbp
	call 0000000180002040h
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	xor bpl,bpl
	mov rdi,rax
	test rax,rax
	je short 00000001806B89E3h
	cmp dword ptr [rax+70h],17h
	je short 00000001806B89DBh
	cmp dword ptr [rax+70h],20h
	je short 00000001806B89DBh
	cmp dword ptr [rax+70h],19h
	jne short 00000001806B89E3h
	mov bpl,1
	xor sil,sil
	jmp short 00000001806B89EBh
	xor sil,sil
	test rdi,rdi
	je short 00000001806B8A13h
	xor edx,edx
	mov rcx,rdi
	call 00000001806F3670h
	test al,al
	jne short 00000001806B8A16h
	xor edx,edx
	mov rcx,rdi
	call 00000001806F35E0h
	test al,al
	jne short 00000001806B8A13h
	cmp dword ptr [rdi+74h],0Ch
	je short 00000001806B8A13h
	cmp dword ptr [rdi+74h],0Bh
	jne short 00000001806B8A16h
	mov sil,1
	test bpl,bpl
	mov rbp,[rsp+40h]
	jne short 00000001806B8A6Ah
	test sil,sil
	jne near ptr 00000001806B8AB7h
	test rdi,rdi
	je near ptr 00000001806B8B82h
	xor edx,edx
	mov rcx,rdi
	call 00000001806EC320h
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806B8B82h
	mov [rax+239h],sil
	mov dword ptr [rbx+88h],0Bh
	mov rdi,[rsp+50h]
	mov rsi,[rsp+48h]
	add rsp,30h
	pop rbx
	ret
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B8B82h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B8B82h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,1
	call 0000000180002040h
	test rdi,rdi
	je near ptr 00000001806B8B82h
	xor r9d,r9d
	xor r8d,r8d
	mov edx,28h
	mov rcx,rdi
	call 00000001806F8F60h
	mov dword ptr [rbx+88h],0Ch
	mov rdi,[rsp+50h]
	mov rsi,[rsp+48h]
	add rsp,30h
	pop rbx
	ret
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	test rax,rax
	je near ptr 00000001806B8830h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B8B82h
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B8B82h
	xor r9d,r9d
	xor r8d,r8d
	mov edx,3
	call 00000001807C8640h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B8B82h
	movss xmm3,dword ptr [183C33EF0h]
	xor r8d,r8d
	mov rdx,[184CADDD0h]
	mov qword ptr [rsp+28h],0
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov rdi,[rsp+50h]
	mov rsi,[rsp+48h]
	mov dword ptr [rbx+88h],0Ah
	mov dword ptr [rbx+0A0h],46h
	add rsp,30h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -48
	004 Compare [0x184EEB655], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {16}
	007 LoadAddress rcx, [0x184C75168]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C932A8]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C39168]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184CADDD0]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 Move [0x184EEB655], 1
	016 Compare [rbx+136], 1
	017 Move stack:0x48, rsi
	018 Move stack:0x50, rdi
	019 JumpIfEqual {206}
	020 Compare [rbx+136], 10
	021 JumpIfEqual {112}
	022 Compare [rbx+136], 11
	023 JumpIfEqual {74}
	024 Compare [rbx+136], 13
	025 JumpIfEqual {49}
	026 Compare [rbx+136], 14
	027 JumpIfEqual {30}
	028 Compare [rbx+136], 12
	029 JumpIfNotEqual {43}
	030 Move rcx, [rbx+320]
	031 Compare rcx, 0
	032 JumpIfEqual {244}
	033 Move r8, 0
	034 Move rdx, 0
	035 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	036 Compare rax, 0
	037 JumpIfLessOrEqual {43}
	038 Move xmm1, [0x183C33DB4]
	039 Move r8, 0
	040 Move rcx, rbx
	041 Call Plant.PlayIdleAnim, rcx, rdx
	042 Move [rbx+136], 1
	043 Move rdi, stack:0x50
	044 Move rsi, stack:0x48
	045 ShiftStack 48
	046 Move rbx, stack:0x0
	047 ShiftStack 8
	048 Return 
	049 Compare [rbx+160], 0
	050 JumpIfNotEqual {43}
	051 Move rcx, [rbx+320]
	052 Compare rcx, 0
	053 JumpIfEqual {244}
	054 Move xmm1, [0x183C33DBC]
	055 Move r9, 0
	056 Move r8, 0
	057 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	058 Move rcx, [rbx+320]
	059 Compare rcx, 0
	060 JumpIfEqual {244}
	061 Move xmm3, [0x183C33DB4]
	062 Move r8, 0
	063 Move rdx, "swallow"
	064 Move stack:0x28, 0
	065 Move stack:0x20, 3
	066 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	067 Move [rbx+136], 14
	068 Move rdi, stack:0x50
	069 Move rsi, stack:0x48
	070 ShiftStack 48
	071 Move rbx, stack:0x0
	072 ShiftStack 8
	073 Return 
	074 Move rcx, [rbx+320]
	075 Compare rcx, 0
	076 JumpIfEqual {244}
	077 Move r8, 0
	078 Move rdx, 0
	079 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	080 Compare rax, 0
	081 JumpIfLessOrEqual {43}
	082 Move rcx, [rbx+320]
	083 Compare rcx, 0
	084 JumpIfEqual {244}
	085 Move xmm3, [0x183C33DB8]
	086 Move r8, 0
	087 Move rdx, "chew"
	088 Move stack:0x20, 0
	089 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	090 Move rcx, [rbx+16]
	091 Compare rcx, 0
	092 JumpIfEqual {244}
	093 Move rdx, 0
	094 Call GameplayActivity.IsIZombieLevel, rcx, rdx
	095 Compare rax, 0
	096 JumpIfEqual {104}
	097 Move rcx, [rbx+320]
	098 Compare rcx, 0
	099 JumpIfEqual {244}
	100 Move r9, 0
	101 Move r8, 0
	102 Move xmm1, 0
	103 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	104 Move [rbx+136], 13
	105 Move [rbx+160], 4000
	106 Move rdi, stack:0x50
	107 Move rsi, stack:0x48
	108 ShiftStack 48
	109 Move rbx, stack:0x0
	110 ShiftStack 8
	111 Return 
	112 Compare [rbx+160], 0
	113 JumpIfNotEqual {43}
	114 Move rax, [rbx+16]
	115 Compare rax, 0
	116 JumpIfEqual {244}
	117 Move r8, [rax+88]
	118 Compare r8, 0
	119 JumpIfEqual {244}
	120 Move rdx, typeof(Reloaded.Services.IAudioService)
	121 Move rcx, 6
	122 Move r9, 61
	123 Move stack:0x40, rbp
	124 Call 0x180002040, rcx, rdx, r8, r9
	125 Move rdx, [rbx+52]
	126 Move r9, 0
	127 Move r8, 0
	128 Move rcx, rbx
	129 Call Plant.FindTargetZombie, rcx, rdx, r8
	130 Move rbp, 0
	131 Move rdi, rax
	132 Compare rax, 0
	133 JumpIfEqual {143}
	134 Compare [rax+112], 23
	135 JumpIfEqual {140}
	136 Compare [rax+112], 32
	137 JumpIfEqual {140}
	138 Compare [rax+112], 25
	139 JumpIfNotEqual {143}
	140 Move rbp, 1
	141 Move rsi, 0
	142 Goto {146}
	143 Move rsi, 0
	144 Compare rdi, 0
	145 JumpIfEqual {160}
	146 Move rdx, 0
	147 Move rcx, rdi
	148 Call Zombie.IsImmobilizied, rcx, rdx
	149 Compare rax, 0
	150 JumpIfNotEqual {161}
	151 Move rdx, 0
	152 Move rcx, rdi
	153 Call Zombie.IsBouncingPogo, rcx, rdx
	154 Compare rax, 0
	155 JumpIfNotEqual {160}
	156 Compare [rdi+116], 12
	157 JumpIfEqual {160}
	158 Compare [rdi+116], 11
	159 JumpIfNotEqual {161}
	160 Move rsi, 1
	161 Compare rbp, 0
	162 Move rbp, stack:0x40
	163 JumpIfNotEqual {182}
	164 Compare rsi, 0
	165 JumpIfNotEqual {199}
	166 Compare rdi, 0
	167 JumpIfEqual {244}
	168 Move rdx, 0
	169 Move rcx, rdi
	170 Call Zombie.DieWithLoot, rcx, rdx
	171 Move rax, [rbx+24]
	172 Compare rax, 0
	173 JumpIfEqual {244}
	174 Move [rax+569], rsi
	175 Move [rbx+136], 11
	176 Move rdi, stack:0x50
	177 Move rsi, stack:0x48
	178 ShiftStack 48
	179 Move rbx, stack:0x0
	180 ShiftStack 8
	181 Return 
	182 Move rax, [rbx+16]
	183 Compare rax, 0
	184 JumpIfEqual {244}
	185 Move r8, [rax+88]
	186 Compare r8, 0
	187 JumpIfEqual {244}
	188 Move rdx, typeof(Reloaded.Services.IAudioService)
	189 Move rcx, 6
	190 Move r9, 1
	191 Call 0x180002040, rcx, rdx, r8, r9
	192 Compare rdi, 0
	193 JumpIfEqual {244}
	194 Move r9, 0
	195 Move r8, 0
	196 Move rdx, 40
	197 Move rcx, rdi
	198 Call Zombie.TakeDamage, rcx, rdx, r8
	199 Move [rbx+136], 12
	200 Move rdi, stack:0x50
	201 Move rsi, stack:0x48
	202 ShiftStack 48
	203 Move rbx, stack:0x0
	204 ShiftStack 8
	205 Return 
	206 Move rdx, [rbx+52]
	207 Move r9, 0
	208 Move r8, 0
	209 Move rcx, rbx
	210 Call Plant.FindTargetZombie, rcx, rdx, r8
	211 Compare rax, 0
	212 JumpIfEqual {43}
	213 Move rcx, [rbx+320]
	214 Compare rcx, 0
	215 JumpIfEqual {244}
	216 Move xmm1, [0x183C33DBC]
	217 Move r9, 0
	218 Move r8, 0
	219 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	220 Move rcx, [rbx+320]
	221 Compare rcx, 0
	222 JumpIfEqual {244}
	223 Move r9, 0
	224 Move r8, 0
	225 Move rdx, 3
	226 Call ReloadedCharacterController.SetAnimLoopType, rcx, rdx, r8
	227 Move rcx, [rbx+320]
	228 Compare rcx, 0
	229 JumpIfEqual {244}
	230 Move xmm3, [0x183C33EF0]
	231 Move r8, 0
	232 Move rdx, "bite"
	233 Move stack:0x28, 0
	234 Move stack:0x20, 3
	235 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	236 Move rdi, stack:0x50
	237 Move rsi, stack:0x48
	238 Move [rbx+136], 10
	239 Move [rbx+160], 70
	240 ShiftStack 48
	241 Move rbx, stack:0x0
	242 ShiftStack 8
	243 Return 
	244 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
