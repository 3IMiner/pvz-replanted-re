# System.Void Deserialize(ref Source.Serialization.ReloadedBinaryReader reader, System.Int32 version)

- 类：`Plant`
- 汇编行数：953

## 反汇编

```asm

Disassembly:
	mov [rsp+20h],rbx
	mov [rsp+18h],r8d
	push rbp
	push rsi
	push rdi
	push r12
	push r13
	push r14
	push r15
	mov rbp,rsp
	sub rsp,40h
	cmp byte ptr [184EEB67Dh],0
	mov r15d,r8d
	mov r12,rdx
	mov rbx,rcx
	jne short 00000001806AC631h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	lea rcx,[184C66E38h]
	call 00000001804FEB70h
	lea rcx,[184C66F08h]
	call 00000001804FEB70h
	lea rcx,[184C66FE0h]
	call 00000001804FEB70h
	lea rcx,[184C67750h]
	call 00000001804FEB70h
	mov byte ptr [184EEB67Dh],1
	xor r9d,r9d
	mov r8d,r15d
	mov rdx,r12
	mov rcx,rbx
	call 00000001806CE400h
	xor r13d,r13d
	lea rdx,[rbp+40h]
	xor r8d,r8d
	mov [rbp+40h],r13d
	mov rcx,r12
	call 000000018063B5F0h
	mov eax,[rbp+40h]
	lea rdx,[rbx+74h]
	xor r8d,r8d
	mov [rbx+70h],eax
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+78h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+7Ch]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+80h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+84h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	xor r8d,r8d
	mov [rbp+40h],r13d
	lea rdx,[rbp+40h]
	mov rcx,r12
	call 000000018063B5F0h
	mov eax,[rbp+40h]
	lea rdx,[rbx+8Ch]
	xor r8d,r8d
	mov [rbx+88h],eax
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+90h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	xor r8d,r8d
	mov [rbp+40h],r13d
	lea rdx,[rbp+40h]
	mov rcx,r12
	call 000000018063B5F0h
	mov eax,[rbp+40h]
	lea rdx,[rbx+98h]
	xor r8d,r8d
	mov [rbx+94h],eax
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+9Ch]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+0A0h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+0A4h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+0A8h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+0ACh]
	xor r8d,r8d
	mov rcx,r12
	call 00000001806AADF0h
	lea rdx,[rbx+0BCh]
	xor r8d,r8d
	mov rcx,r12
	call 00000001806AADF0h
	lea rdx,[rbx+0CCh]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+0D0h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+0D4h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	xor r8d,r8d
	mov [rbp+40h],r13d
	lea rdx,[rbp+40h]
	mov rcx,r12
	call 000000018063B5F0h
	mov ecx,[rbp+40h]
	xor edx,edx
	call 00000001806BE7D0h
	lea rdx,[rbx+0DCh]
	mov [rbx+0D8h],eax
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	xor r8d,r8d
	mov [rbp+40h],r13d
	lea rdx,[rbp+40h]
	mov rcx,r12
	call 000000018063B5F0h
	mov ecx,[rbp+40h]
	xor edx,edx
	call 00000001806BE7D0h
	xor r8d,r8d
	mov [rbx+0F4h],eax
	lea rdx,[rbp+40h]
	mov [rbp+40h],r13d
	mov rcx,r12
	call 000000018063B5F0h
	mov ecx,[rbp+40h]
	xor edx,edx
	call 00000001806BE7D0h
	lea rdx,[rbx+0FCh]
	mov [rbx+0F8h],eax
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+100h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+104h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+108h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+10Ch]
	xor r8d,r8d
	mov rcx,r12
	call 000000018060D8C0h
	lea rdx,[rbx+110h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018060D8C0h
	xor r8d,r8d
	mov [rbp+40h],r13d
	lea rdx,[rbp+40h]
	mov rcx,r12
	call 000000018063B5F0h
	mov ecx,[rbp+40h]
	xor edx,edx
	call 00000001806BE7D0h
	mov [rbx+120h],eax
	lea rdx,[rbx+124h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B5F0h
	xor r8d,r8d
	mov [rbp+40h],r13d
	lea rdx,[rbp+40h]
	mov rcx,r12
	call 000000018063B5F0h
	mov eax,[rbp+40h]
	lea rdx,[rbp+40h]
	xor r8d,r8d
	mov [rbx+128h],eax
	mov rcx,r12
	mov [rbp+40h],r13d
	call 000000018063B5F0h
	mov eax,[rbp+40h]
	lea rdx,[rbx+130h]
	xor r8d,r8d
	mov [rbx+12Ch],eax
	mov rcx,r12
	call 000000018063B5F0h
	lea rdx,[rbx+134h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B2A0h
	lea rdx,[rbx+135h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B2A0h
	lea rdx,[rbx+136h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B2A0h
	lea rdx,[rbx+137h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B2A0h
	lea rdx,[rbx+138h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B2A0h
	lea rdx,[rbx+139h]
	xor r8d,r8d
	mov rcx,r12
	call 000000018063B2A0h
	cmp r15d,5
	jl short 00000001806AC9BAh
	xor r8d,r8d
	mov [rbp+40h],r13d
	lea rdx,[rbp+40h]
	mov rcx,r12
	call 000000018063B5F0h
	mov ecx,[rbp+40h]
	xor edx,edx
	call 00000001806BE7D0h
	mov [rbx+13Ch],eax
	xor dil,dil
	mov [rbp+40h],dil
	cmp r15d,0Dh
	jl short 00000001806AC9DAh
	xor r8d,r8d
	lea rdx,[rbp+40h]
	mov rcx,r12
	call 000000018063B2A0h
	movzx edi,byte ptr [rbp+40h]
	xor sil,sil
	mov [rbp+40h],sil
	cmp r15d,0Eh
	jl short 00000001806AC9FAh
	xor r8d,r8d
	lea rdx,[rbp+40h]
	mov rcx,r12
	call 000000018063B2A0h
	movzx esi,byte ptr [rbp+40h]
	mov rcx,[184C2D478h]
	mov r14,[rbx+140h]
	cmp [rcx+0E4h],r13d
	jne short 00000001806ACA16h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,r14
	call 0000000183832770h
	test al,al
	je short 00000001806ACA7Bh
	test dil,dil
	je short 00000001806ACA31h
	mov eax,r13d
	jmp short 00000001806ACA37h
	test sil,sil
	sete al
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806ACD15h
	mov edx,[rbx+70h]
	xor r9d,r9d
	mov [rsp+38h],r13
	mov r8,rbx
	mov [rsp+30h],sil
	mov [rsp+28h],al
	mov [rsp+20h],dil
	call 00000001807DBAB0h
	lea rcx,[rbx+140h]
	mov [rbx+140h],rax
	mov rdx,rax
	call 00000001804FDEA0h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806ACD15h
	mov r9,[rcx]
	mov r8d,r15d
	mov rdx,r12
	mov rax,[r9+298h]
	mov r9,[r9+2A0h]
	call rax
	xor r8d,r8d
	mov [rbp+40h],r13d
	lea rdx,[rbp+40h]
	mov rcx,r12
	call 000000018063B5F0h
	mov edi,r13d
	mov esi,20h
	mov r13d,[rbp+40h]
	test r13d,r13d
	jle short 00000001806ACB0Fh
	mov r14d,esi
	nop dword ptr [rax+rax]
	mov rax,[rbx+118h]
	test rax,rax
	je near ptr 00000001806ACD15h
	cmp edi,[rax+18h]
	jae near ptr 00000001806ACD2Bh
	mov rcx,[r14+rax]
	test rcx,rcx
	je near ptr 00000001806ACD15h
	xor r9d,r9d
	mov r8d,r15d
	mov rdx,r12
	call 00000001806C5200h
	inc edi
	add r14,8
	cmp edi,r13d
	jl short 00000001806ACAD0h
	xor r8d,r8d
	mov dword ptr [rbp+48h],0
	lea rdx,[rbp+48h]
	mov rcx,r12
	call 000000018063B5F0h
	xor edi,edi
	cmp [rbp+48h],edi
	jle near ptr 00000001806ACCE1h
	mov rax,[rbx+150h]
	test rax,rax
	je near ptr 00000001806ACD15h
	cmp edi,[rax+18h]
	jae near ptr 00000001806ACD2Bh
	mov rcx,[184C2D478h]
	mov r14,[rsi+rax]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806ACB62h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,r14
	call 0000000183832900h
	test al,al
	je short 00000001806ACBD3h
	mov rax,[rbx+150h]
	test rax,rax
	je near ptr 00000001806ACD15h
	cmp edi,[rax+18h]
	jae near ptr 00000001806ACD2Bh
	mov rcx,[rsi+rax]
	test rcx,rcx
	je near ptr 00000001806ACD15h
	xor edx,edx
	call 00000001807B45E0h
	mov rcx,[rbx+150h]
	test rcx,rcx
	je near ptr 00000001806ACD15h
	cmp edi,[rcx+18h]
	jae near ptr 00000001806ACD2Bh
	mov qword ptr [rsi+rcx],0
	xor edx,edx
	movsxd rax,edi
	lea rcx,[rcx+rax*8]
	add rcx,20h
	call 00000001804FDEA0h
	xor r8d,r8d
	mov byte ptr [rbp+40h],0
	lea rdx,[rbp+40h]
	mov rcx,r12
	call 000000018063B2A0h
	cmp byte ptr [rbp+40h],0
	je near ptr 00000001806ACCD2h
	mov rax,[rbx+118h]
	test rax,rax
	je near ptr 00000001806ACD15h
	cmp edi,[rax+18h]
	jae near ptr 00000001806ACD2Bh
	mov rcx,[rsi+rax]
	test rcx,rcx
	je near ptr 00000001806ACD15h
	mov r15d,[rcx+20h]
	test r15d,r15d
	je near ptr 00000001806ACCD2h
	mov rcx,[rbx+140h]
	mov r14,[rbx+150h]
	mov r13,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806ACD15h
	xor edx,edx
	call 0000000183815A20h
	test r13,r13
	je near ptr 00000001806ACD15h
	xor r9d,r9d
	mov r8,rax
	mov edx,r15d
	mov rcx,r13
	call 00000001807DB970h
	mov r15,rax
	test r14,r14
	je near ptr 00000001806ACD15h
	test rax,rax
	je short 00000001806ACC88h
	mov rdx,[r14]
	mov rcx,rax
	mov rdx,[rdx+40h]
	call 00000001804FDEC0h
	test rax,rax
	je near ptr 00000001806ACD1Bh
	cmp edi,[r14+18h]
	jae near ptr 00000001806ACD2Bh
	movsxd rax,edi
	mov rdx,r15
	add rax,4
	mov [rsi+r14],r15
	lea rcx,[r14+rax*8]
	call 00000001804FDEA0h
	mov rax,[rbx+150h]
	test rax,rax
	je short 00000001806ACD15h
	cmp edi,[rax+18h]
	jae short 00000001806ACD2Bh
	mov rcx,[rsi+rax]
	test rcx,rcx
	je short 00000001806ACD15h
	mov r8d,[rbp+50h]
	xor r9d,r9d
	mov rdx,r12
	call 00000001807B4530h
	inc edi
	add rsi,8
	cmp edi,[rbp+48h]
	jl near ptr 00000001806ACB30h
	cmp byte ptr [rbx+139h],0
	je short 00000001806ACCFDh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806ACD15h
	xor edx,edx
	call 00000001807B6EF0h
	mov rbx,[rsp+98h]
	add rsp,40h
	pop r15
	pop r14
	pop r13
	pop r12
	pop rdi
	pop rsi
	pop rbp
	ret
	call 00000001804FEE20h
	int 3
	call 00000001804FE790h
	mov rcx,rax
	xor edx,edx
	call 00000001804FEDE0h
	int 3
	call 00000001804FEE10h

ISIL:
	001 Move stack:0x20, rbx
	002 Move stack:0x18, r8
	003 ShiftStack -8
	004 Move stack:0x0, rbp
	005 ShiftStack -8
	006 Move stack:0x0, rsi
	007 ShiftStack -8
	008 Move stack:0x0, rdi
	009 ShiftStack -8
	010 Move stack:0x0, r12
	011 ShiftStack -8
	012 Move stack:0x0, r13
	013 ShiftStack -8
	014 Move stack:0x0, r14
	015 ShiftStack -8
	016 Move stack:0x0, r15
	017 Move rbp, rsp
	018 ShiftStack -64
	019 Compare [0x184EEB67D], 0
	020 Move r15, r8
	021 Move r12, rdx
	022 Move rbx, rcx
	023 JumpIfNotEqual {35}
	024 LoadAddress rcx, [0x184C2D478]
	025 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	026 LoadAddress rcx, [0x184C66E38]
	027 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	028 LoadAddress rcx, [0x184C66F08]
	029 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	030 LoadAddress rcx, [0x184C66FE0]
	031 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	032 LoadAddress rcx, [0x184C67750]
	033 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	034 Move [0x184EEB67D], 1
	035 Move r9, 0
	036 Move r8, r15
	037 Move rdx, r12
	038 Move rcx, rbx
	039 Call ReloadedObject.Deserialize, rcx, rdx, r8
	040 Move r13, 0
	041 LoadAddress rdx, [rbp+64]
	042 Move r8, 0
	043 Move [rbp+64], r13
	044 Move rcx, r12
	045 Call 0x18063B5F0, rcx, rdx, r8, r9
	046 Move rax, [rbp+64]
	047 LoadAddress rdx, [rbx+116]
	048 Move r8, 0
	049 Move [rbx+112], rax
	050 Move rcx, r12
	051 Call 0x18063B5F0, rcx, rdx, r8, r9
	052 LoadAddress rdx, [rbx+120]
	053 Move r8, 0
	054 Move rcx, r12
	055 Call 0x18063B5F0, rcx, rdx, r8, r9
	056 LoadAddress rdx, [rbx+124]
	057 Move r8, 0
	058 Move rcx, r12
	059 Call 0x18063B5F0, rcx, rdx, r8, r9
	060 LoadAddress rdx, [rbx+128]
	061 Move r8, 0
	062 Move rcx, r12
	063 Call 0x18063B5F0, rcx, rdx, r8, r9
	064 LoadAddress rdx, [rbx+132]
	065 Move r8, 0
	066 Move rcx, r12
	067 Call 0x18063B5F0, rcx, rdx, r8, r9
	068 Move r8, 0
	069 Move [rbp+64], r13
	070 LoadAddress rdx, [rbp+64]
	071 Move rcx, r12
	072 Call 0x18063B5F0, rcx, rdx, r8, r9
	073 Move rax, [rbp+64]
	074 LoadAddress rdx, [rbx+140]
	075 Move r8, 0
	076 Move [rbx+136], rax
	077 Move rcx, r12
	078 Call 0x18063B5F0, rcx, rdx, r8, r9
	079 LoadAddress rdx, [rbx+144]
	080 Move r8, 0
	081 Move rcx, r12
	082 Call 0x18063B5F0, rcx, rdx, r8, r9
	083 Move r8, 0
	084 Move [rbp+64], r13
	085 LoadAddress rdx, [rbp+64]
	086 Move rcx, r12
	087 Call 0x18063B5F0, rcx, rdx, r8, r9
	088 Move rax, [rbp+64]
	089 LoadAddress rdx, [rbx+152]
	090 Move r8, 0
	091 Move [rbx+148], rax
	092 Move rcx, r12
	093 Call 0x18063B5F0, rcx, rdx, r8, r9
	094 LoadAddress rdx, [rbx+156]
	095 Move r8, 0
	096 Move rcx, r12
	097 Call 0x18063B5F0, rcx, rdx, r8, r9
	098 LoadAddress rdx, [rbx+160]
	099 Move r8, 0
	100 Move rcx, r12
	101 Call 0x18063B5F0, rcx, rdx, r8, r9
	102 LoadAddress rdx, [rbx+164]
	103 Move r8, 0
	104 Move rcx, r12
	105 Call 0x18063B5F0, rcx, rdx, r8, r9
	106 LoadAddress rdx, [rbx+168]
	107 Move r8, 0
	108 Move rcx, r12
	109 Call 0x18063B5F0, rcx, rdx, r8, r9
	110 LoadAddress rdx, [rbx+172]
	111 Move r8, 0
	112 Move rcx, r12
	113 Call 0x1806AADF0, rcx, rdx, r8, r9
	114 LoadAddress rdx, [rbx+188]
	115 Move r8, 0
	116 Move rcx, r12
	117 Call 0x1806AADF0, rcx, rdx, r8, r9
	118 LoadAddress rdx, [rbx+204]
	119 Move r8, 0
	120 Move rcx, r12
	121 Call 0x18063B5F0, rcx, rdx, r8, r9
	122 LoadAddress rdx, [rbx+208]
	123 Move r8, 0
	124 Move rcx, r12
	125 Call 0x18063B5F0, rcx, rdx, r8, r9
	126 LoadAddress rdx, [rbx+212]
	127 Move r8, 0
	128 Move rcx, r12
	129 Call 0x18063B5F0, rcx, rdx, r8, r9
	130 Move r8, 0
	131 Move [rbp+64], r13
	132 LoadAddress rdx, [rbp+64]
	133 Move rcx, r12
	134 Call 0x18063B5F0, rcx, rdx, r8, r9
	135 Move rcx, [rbp+64]
	136 Move rdx, 0
	137 Call 0x1806BE7D0, rcx, rdx
	138 LoadAddress rdx, [rbx+220]
	139 Move [rbx+216], rax
	140 Move r8, 0
	141 Move rcx, r12
	142 Call 0x18063B5F0, rcx, rdx, r8, r9
	143 Move r8, 0
	144 Move [rbp+64], r13
	145 LoadAddress rdx, [rbp+64]
	146 Move rcx, r12
	147 Call 0x18063B5F0, rcx, rdx, r8, r9
	148 Move rcx, [rbp+64]
	149 Move rdx, 0
	150 Call 0x1806BE7D0, rcx, rdx
	151 Move r8, 0
	152 Move [rbx+244], rax
	153 LoadAddress rdx, [rbp+64]
	154 Move [rbp+64], r13
	155 Move rcx, r12
	156 Call 0x18063B5F0, rcx, rdx, r8, r9
	157 Move rcx, [rbp+64]
	158 Move rdx, 0
	159 Call 0x1806BE7D0, rcx, rdx
	160 LoadAddress rdx, [rbx+252]
	161 Move [rbx+248], rax
	162 Move r8, 0
	163 Move rcx, r12
	164 Call 0x18063B5F0, rcx, rdx, r8, r9
	165 LoadAddress rdx, [rbx+256]
	166 Move r8, 0
	167 Move rcx, r12
	168 Call 0x18063B5F0, rcx, rdx, r8, r9
	169 LoadAddress rdx, [rbx+260]
	170 Move r8, 0
	171 Move rcx, r12
	172 Call 0x18063B5F0, rcx, rdx, r8, r9
	173 LoadAddress rdx, [rbx+264]
	174 Move r8, 0
	175 Move rcx, r12
	176 Call 0x18063B5F0, rcx, rdx, r8, r9
	177 LoadAddress rdx, [rbx+268]
	178 Move r8, 0
	179 Move rcx, r12
	180 Call 0x18060D8C0, rcx, rdx, r8, r9
	181 LoadAddress rdx, [rbx+272]
	182 Move r8, 0
	183 Move rcx, r12
	184 Call 0x18060D8C0, rcx, rdx, r8, r9
	185 Move r8, 0
	186 Move [rbp+64], r13
	187 LoadAddress rdx, [rbp+64]
	188 Move rcx, r12
	189 Call 0x18063B5F0, rcx, rdx, r8, r9
	190 Move rcx, [rbp+64]
	191 Move rdx, 0
	192 Call 0x1806BE7D0, rcx, rdx
	193 Move [rbx+288], rax
	194 LoadAddress rdx, [rbx+292]
	195 Move r8, 0
	196 Move rcx, r12
	197 Call 0x18063B5F0, rcx, rdx, r8, r9
	198 Move r8, 0
	199 Move [rbp+64], r13
	200 LoadAddress rdx, [rbp+64]
	201 Move rcx, r12
	202 Call 0x18063B5F0, rcx, rdx, r8, r9
	203 Move rax, [rbp+64]
	204 LoadAddress rdx, [rbp+64]
	205 Move r8, 0
	206 Move [rbx+296], rax
	207 Move rcx, r12
	208 Move [rbp+64], r13
	209 Call 0x18063B5F0, rcx, rdx, r8, r9
	210 Move rax, [rbp+64]
	211 LoadAddress rdx, [rbx+304]
	212 Move r8, 0
	213 Move [rbx+300], rax
	214 Move rcx, r12
	215 Call 0x18063B5F0, rcx, rdx, r8, r9
	216 LoadAddress rdx, [rbx+308]
	217 Move r8, 0
	218 Move rcx, r12
	219 Call 0x18063B2A0, rcx, rdx, r8, r9
	220 LoadAddress rdx, [rbx+309]
	221 Move r8, 0
	222 Move rcx, r12
	223 Call 0x18063B2A0, rcx, rdx, r8, r9
	224 LoadAddress rdx, [rbx+310]
	225 Move r8, 0
	226 Move rcx, r12
	227 Call 0x18063B2A0, rcx, rdx, r8, r9
	228 LoadAddress rdx, [rbx+311]
	229 Move r8, 0
	230 Move rcx, r12
	231 Call 0x18063B2A0, rcx, rdx, r8, r9
	232 LoadAddress rdx, [rbx+312]
	233 Move r8, 0
	234 Move rcx, r12
	235 Call 0x18063B2A0, rcx, rdx, r8, r9
	236 LoadAddress rdx, [rbx+313]
	237 Move r8, 0
	238 Move rcx, r12
	239 Call 0x18063B2A0, rcx, rdx, r8, r9
	240 Compare r15, 5
	241 JumpIfLess {251}
	242 Move r8, 0
	243 Move [rbp+64], r13
	244 LoadAddress rdx, [rbp+64]
	245 Move rcx, r12
	246 Call 0x18063B5F0, rcx, rdx, r8, r9
	247 Move rcx, [rbp+64]
	248 Move rdx, 0
	249 Call 0x1806BE7D0, rcx, rdx
	250 Move [rbx+316], rax
	251 Move rdi, 0
	252 Move [rbp+64], rdi
	253 Compare r15, 13
	254 JumpIfLess {260}
	255 Move r8, 0
	256 LoadAddress rdx, [rbp+64]
	257 Move rcx, r12
	258 Call 0x18063B2A0, rcx, rdx, r8, r9
	259 Move rdi, [rbp+64]
	260 Move rsi, 0
	261 Move [rbp+64], rsi
	262 Compare r15, 14
	263 JumpIfLess {269}
	264 Move r8, 0
	265 LoadAddress rdx, [rbp+64]
	266 Move rcx, r12
	267 Call 0x18063B2A0, rcx, rdx, r8, r9
	268 Move rsi, [rbp+64]
	269 Move rcx, typeof(UnityEngine.Object)
	270 Move r14, [rbx+320]
	271 Compare [rcx+228], r13
	272 JumpIfNotEqual {274}
	273 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	274 Move r8, 0
	275 Move rdx, 0
	276 Move rcx, r14
	277 Call Object.op_Equality, rcx, rdx, r8
	278 Compare rax, 0
	279 JumpIfEqual {301}
	280 Compare rdi, 0
	281 JumpIfEqual {284}
	282 Move rax, r13
	283 Goto {286}
	284 Compare rsi, 0
	285 NotImplemented "sete al"
	286 Move rcx, [rbx+16]
	287 Compare rcx, 0
	288 JumpIfEqual {474}
	289 Move rdx, [rbx+112]
	290 Move r9, 0
	291 Move stack:0x38, r13
	292 Move r8, rbx
	293 Move stack:0x30, rsi
	294 Move stack:0x28, rax
	295 Move stack:0x20, rdi
	296 Call GameplayActivity.CreatePlantController, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	297 LoadAddress rcx, [rbx+320]
	298 Move [rbx+320], rax
	299 Move rdx, rax
	300 Call 0x1804FDEA0, rcx, rdx, r8, r9
	301 Move rcx, [rbx+320]
	302 Compare rcx, 0
	303 JumpIfEqual {474}
	304 Move r9, [rcx]
	305 Move r8, r15
	306 Move rdx, r12
	307 Move rax, [r9+664]
	308 Move r9, [r9+672]
	309 Call rax
	310 Move r8, 0
	311 Move [rbp+64], r13
	312 LoadAddress rdx, [rbp+64]
	313 Move rcx, r12
	314 Call 0x18063B5F0, rcx, rdx, r8, r9
	315 Move rdi, r13
	316 Move rsi, 32
	317 Move r13, [rbp+64]
	318 Compare r13, 0
	319 JumpIfLessOrEqual {338}
	320 Move r14, rsi
	321 Nop 
	322 Move rax, [rbx+280]
	323 Compare rax, 0
	324 JumpIfEqual {474}
	325 Compare rdi, [rax+24]
	326 JumpIfGreaterOrEqual {481}
	327 Move rcx, [r14+rax]
	328 Compare rcx, 0
	329 JumpIfEqual {474}
	330 Move r9, 0
	331 Move r8, r15
	332 Move rdx, r12
	333 Call MagnetItem.Deserialize, rcx, rdx, r8
	334 Add rdi, rdi, 1
	335 Add r14, r14, 8
	336 Compare rdi, r13
	337 JumpIfLess {322}
	338 Move r8, 0
	339 Move [rbp+72], 0
	340 LoadAddress rdx, [rbp+72]
	341 Move rcx, r12
	342 Call 0x18063B5F0, rcx, rdx, r8, r9
	343 Move rdi, 0
	344 Compare [rbp+72], rdi
	345 JumpIfLessOrEqual {450}
	346 Move rax, [rbx+336]
	347 Compare rax, 0
	348 JumpIfEqual {474}
	349 Compare rdi, [rax+24]
	350 JumpIfGreaterOrEqual {481}
	351 Move rcx, typeof(UnityEngine.Object)
	352 Move r14, [rsi+rax]
	353 Compare [rcx+228], 0
	354 JumpIfNotEqual {356}
	355 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	356 Move r8, 0
	357 Move rdx, 0
	358 Move rcx, r14
	359 Call Object.op_Inequality, rcx, rdx, r8
	360 Compare rax, 0
	361 JumpIfEqual {383}
	362 Move rax, [rbx+336]
	363 Compare rax, 0
	364 JumpIfEqual {474}
	365 Compare rdi, [rax+24]
	366 JumpIfGreaterOrEqual {481}
	367 Move rcx, [rsi+rax]
	368 Compare rcx, 0
	369 JumpIfEqual {474}
	370 Move rdx, 0
	371 Call MagnetItemController.Die, rcx, rdx
	372 Move rcx, [rbx+336]
	373 Compare rcx, 0
	374 JumpIfEqual {474}
	375 Compare rdi, [rcx+24]
	376 JumpIfGreaterOrEqual {481}
	377 Move [rsi+rcx], 0
	378 Move rdx, 0
	379 Move rax, rdi
	380 LoadAddress rcx, [rcx+rax*8]
	381 Add rcx, rcx, 32
	382 Call 0x1804FDEA0, rcx, rdx, r8, r9
	383 Move r8, 0
	384 Move [rbp+64], 0
	385 LoadAddress rdx, [rbp+64]
	386 Move rcx, r12
	387 Call 0x18063B2A0, rcx, rdx, r8, r9
	388 Compare [rbp+64], 0
	389 JumpIfEqual {446}
	390 Move rax, [rbx+280]
	391 Compare rax, 0
	392 JumpIfEqual {474}
	393 Compare rdi, [rax+24]
	394 JumpIfGreaterOrEqual {481}
	395 Move rcx, [rsi+rax]
	396 Compare rcx, 0
	397 JumpIfEqual {474}
	398 Move r15, [rcx+32]
	399 Compare r15, 0
	400 JumpIfEqual {446}
	401 Move rcx, [rbx+320]
	402 Move r14, [rbx+336]
	403 Move r13, [rbx+16]
	404 Compare rcx, 0
	405 JumpIfEqual {474}
	406 Move rdx, 0
	407 Call Component.get_transform, rcx, rdx
	408 Compare r13, 0
	409 JumpIfEqual {474}
	410 Move r9, 0
	411 Move r8, rax
	412 Move rdx, r15
	413 Move rcx, r13
	414 Call GameplayActivity.CreateMagnetItemController, rcx, rdx, r8
	415 Move r15, rax
	416 Compare r14, 0
	417 JumpIfEqual {474}
	418 Compare rax, 0
	419 JumpIfEqual {426}
	420 Move rdx, [r14]
	421 Move rcx, rax
	422 Move rdx, [rdx+64]
	423 Call 0x1804FDEC0, rcx, rdx, r8, r9
	424 Compare rax, 0
	425 JumpIfEqual {476}
	426 Compare rdi, [r14+24]
	427 JumpIfGreaterOrEqual {481}
	428 Move rax, rdi
	429 Move rdx, r15
	430 Add rax, rax, 4
	431 Move [rsi+r14], r15
	432 LoadAddress rcx, [r14+rax*8]
	433 Call 0x1804FDEA0, rcx, rdx, r8, r9
	434 Move rax, [rbx+336]
	435 Compare rax, 0
	436 JumpIfEqual {474}
	437 Compare rdi, [rax+24]
	438 JumpIfGreaterOrEqual {481}
	439 Move rcx, [rsi+rax]
	440 Compare rcx, 0
	441 JumpIfEqual {474}
	442 Move r8, [rbp+80]
	443 Move r9, 0
	444 Move rdx, r12
	445 Call MagnetItemController.Deserialize, rcx, rdx, r8
	446 Add rdi, rdi, 1
	447 Add rsi, rsi, 8
	448 Compare rdi, [rbp+72]
	449 JumpIfLess {346}
	450 Compare [rbx+313], 0
	451 JumpIfEqual {457}
	452 Move rcx, [rbx+320]
	453 Compare rcx, 0
	454 JumpIfEqual {474}
	455 Move rdx, 0
	456 Call PlantController.EnableGrayscale, rcx, rdx
	457 Move rbx, stack:0x98
	458 ShiftStack 64
	459 Move r15, stack:0x0
	460 ShiftStack 8
	461 Move r14, stack:0x0
	462 ShiftStack 8
	463 Move r13, stack:0x0
	464 ShiftStack 8
	465 Move r12, stack:0x0
	466 ShiftStack 8
	467 Move rdi, stack:0x0
	468 ShiftStack 8
	469 Move rsi, stack:0x0
	470 ShiftStack 8
	471 Move rbp, stack:0x0
	472 ShiftStack 8
	473 Return 
	474 Call 0x1804FEE20, rcx, rdx, r8, r9
	475 Interrupt 
	476 Call 0x1804FE790, rcx, rdx, r8, r9
	477 Move rcx, rax
	478 Move rdx, 0
	479 Call 0x1804FEDE0, rcx, rdx, r8, r9
	480 Interrupt 
	481 Call 0x1804FEE10, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
